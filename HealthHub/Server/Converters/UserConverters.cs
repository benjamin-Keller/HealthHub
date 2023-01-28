using HealthHub.Shared;

namespace HealthHub.Server.Converters
{
    public static class UserConverters
    {
        public static ApplicationUser ToApplicationUser(this AddUserViewModel model)
        {
            return new ApplicationUser
            {
                FirstName = model.FirstName,
                SecondName = model.SecondName ?? "",
                LastName = model.LastName,
                Email = model.Email,
                IdNumber = model.IdNumber,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Email,
            };
        }
    }
}
