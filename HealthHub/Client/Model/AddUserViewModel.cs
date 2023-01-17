using System.ComponentModel.DataAnnotations;

namespace HealthHub.Client.Model;

public class AddUserViewModel
{
    [Required(ErrorMessage = "An Email is required")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "A Password is required")]
    [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm your Password")]
    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    public string Password2 { get; set; }
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
