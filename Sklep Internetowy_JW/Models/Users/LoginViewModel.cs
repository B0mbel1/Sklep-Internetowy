using System.ComponentModel.DataAnnotations;

namespace Sklep_Internetowy_JW.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić login")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
