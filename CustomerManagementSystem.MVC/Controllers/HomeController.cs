using CustomerManagementSystem.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerManagementSystem.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Home/About
        public IActionResult About()
        {
            ViewBag.Message = "Customer Management System MVC Web Application";
            return View();
        }

        // GET: Home/Contact
        public IActionResult Contact()
        {
            ViewBag.Message = "https://ak4m410x01.vercel.app";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // GET: Home/Error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}