using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_JW.DAL;
using Sklep_Internetowy_JW.Models;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace Sklep_Internetowy_JW.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;
        IWebHostEnvironment webHost;

        public FilmsController(FilmsContext db, IWebHostEnvironment webHost)
        {
            this.db = db;
            this.webHost = webHost;
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

        [HttpGet]
        public IActionResult AddFilm()
        {
            AddViewModel model = new AddViewModel();
            model.AllCategories = db.Categories.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddFilm(AddViewModel model)
        {
            var posterFolderPath = Path.Combine(webHost.WebRootPath, "posters");
            var uniquePosterName = model.Poster.FileName + "_" + Guid.NewGuid() + Path.GetExtension(model.Poster.FileName);
            var filePath = Path.Combine(posterFolderPath, uniquePosterName);
            model.Poster.CopyTo(new FileStream(filePath, FileMode.Create));
            model.NewFilm.Poster = uniquePosterName;
            db.Films.Add(model.NewFilm);
            db.SaveChanges();
            return RedirectToAction("AddFilm");
        }
        public IActionResult Images()
        {
            var films = db.Films.ToList(); 
            return View(films);
        }

        //TODO dodać łaną tabele by się wyswietlaly obrazy
    }
}
