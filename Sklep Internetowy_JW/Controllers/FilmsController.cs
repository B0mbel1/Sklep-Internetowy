using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_JW.DAL;
using Sklep_Internetowy_JW.Models;

namespace Sklep_Internetowy_JW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult ProductList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name == categoryName).Single();

            var films = category.Films.ToList();


            return View(films);
        }

        public IActionResult Details(int filmId)
        {
            db.Categories.Find(db.Films.Find(filmId).CategoryId);

            var film = db.Films.Find(filmId);

            return View(film); 
        }
        public IActionResult Images()
        {
            var films = db.Films.ToList(); 
            return View(films);
        }

        //TODO dodać łaną tabele by się wyswietlaly obrazy
    }
}
