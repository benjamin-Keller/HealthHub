using System.ComponentModel.DataAnnotations;

namespace HealthHub.Shared
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "An Email is required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "A First Name is required")]
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        [Required(ErrorMessage = "A Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "An ID Number is required")]
        public string IdNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
