using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_JW.DAL;
using Sklep_Internetowy_JW.Infrastructure;

namespace Sklep_Internetowy_JW.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var cart = CartManager.GetItems(HttpContext.Session);

            ViewBag.Total = CartManager.GetCartValue(HttpContext.Session);

            return View(cart);
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, db, filmId);

            return RedirectToAction("Index");
        }
    }
}
