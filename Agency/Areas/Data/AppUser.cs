using Microsoft.AspNetCore.Identity;

namespace Agency.Areas.Data
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
