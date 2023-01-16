using Microsoft.AspNetCore.Identity;

namespace HealthHub.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
    }
}