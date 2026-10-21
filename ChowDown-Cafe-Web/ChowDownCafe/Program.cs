
using Microsoft.EntityFrameworkCore;
using ChowDownCafe.Data;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Register MVC services and API controllers.
builder.Services.AddControllersWithViews();

// Connect to the ChowDown database.
builder.Services.AddDbContext<ChowDownDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ChowDownConnection")));

// Configure staff cookie authentication.
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.Cookie.Name = "ChowDownStaffAuth";
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy =
            CookieSecurePolicy.Always;
        options.ExpireTimeSpan = TimeSpan.FromHours(8);
        options.SlidingExpiration = true;
    });

// Enable authorization.
builder.Services.AddAuthorization();

// Build the application.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Register attribute-routed API controllers.
app.MapControllers();

// Keep the existing MVC website routes.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
