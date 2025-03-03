using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_JW.Models;
using System.Diagnostics;

namespace Sklep_Internetowy_JW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}