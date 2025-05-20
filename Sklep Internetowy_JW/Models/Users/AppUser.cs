using Microsoft.AspNetCore.Identity;

namespace Sklep_Internetowy_JW.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
