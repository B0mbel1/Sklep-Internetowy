using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_JW.DAL;
using Sklep_Internetowy_JW.Infrastructure;
using Sklep_Internetowy_JW.Models;

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

        public IActionResult RemoveFromCart(int id)
        {
            var model = new RemoveViewModel()
            {
                itemQuantity = CartManager.RemoveFromCart(HttpContext.Session, id),
                itemId = id,
                cartValue = CartManager.GetCartValue(HttpContext.Session)
            };
            return Json(model);
        }
    }
}
