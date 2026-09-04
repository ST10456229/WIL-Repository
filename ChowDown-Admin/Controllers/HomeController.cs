using System.Diagnostics;
using CHOWDOWN.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHOWDOWN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ====== CHOW DOWN PAGES ======

        // Page 1: Home/Newsletter (UI2)
        public IActionResult Index()
        {
            return View();
        }

        // Page 2: Staff Access Portal (UI3)
        public IActionResult StaffPortal()
        {
            return View();
        }

        // Page 3: Stock Entry Form (UI4)
        public IActionResult StockEntry()
        {
            return View();
        }

        // Page 4: Inventory Ledger (UI5)
        public IActionResult Inventory()
        {
            return View();
        }

        // Page 5: Item Detail View (UI6)
        public IActionResult ItemDetail()
        {
            return View();
        }

        // ====== DEFAULT ASP.NET CORE PAGES ======

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}