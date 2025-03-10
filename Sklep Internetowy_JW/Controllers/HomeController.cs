using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_JW.DAL;
using Sklep_Internetowy_JW.Models;
using System.Diagnostics;

namespace Sklep_Internetowy_JW.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var categories = db.Categories.ToList();

            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FooterSites(string siteName)
        {
            return View(siteName,new List<Category>());
        }
    }
}