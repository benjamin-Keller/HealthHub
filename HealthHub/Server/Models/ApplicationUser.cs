using Microsoft.AspNetCore.Identity;
using static HealthHub.Shared.Enumerables;

namespace HealthHub.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
    }
}