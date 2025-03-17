using Microsoft.AspNetCore.Mvc;
using Sklep_Internetowy_JW.DAL;

namespace Sklep_Internetowy_JW.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = db.Categories.ToList();
            return await Task.FromResult(View("_Menu", categories));
        }
    }
}


