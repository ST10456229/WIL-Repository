using Microsoft.AspNetCore.Mvc;

namespace CHOWDOWN.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Admin/Inventory
        public IActionResult Inventory()
        {
            return View();
        }

        // GET: Admin/StockEntry
        public IActionResult StockEntry()
        {
            return View();
        }

        // GET: Admin/Orders
        public IActionResult Orders()
        {
            return View();
        }

        // GET: Admin/Reports
        public IActionResult Reports()
        {
            return View();
        }

        // GET: Admin/Promotions
        public IActionResult Promotions()
        {
            return View();
        }

        // GET: Admin/Login (if not logged in)
        public IActionResult Login()
        {
            return View();
        }

        // GET: Admin/Logout
        public IActionResult Logout()
        {
            // Add logout logic here
            return RedirectToAction("Login");
        }
    }
}