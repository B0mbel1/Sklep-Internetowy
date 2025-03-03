using System.ComponentModel.DataAnnotations;

namespace Sklep_Internetowy_JW.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
