namespace Sklep_Internetowy_JW.Models
{
    public class AddFilmViewModel
    {
        public List<Category> AllCategories { get; set; }

        public Film NewFilm { get; set; }

        public IFormFile Poster { get; set; }
    }
}
