using System.ComponentModel.DataAnnotations;

namespace StudyRoom.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Valid Email Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Valid Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}