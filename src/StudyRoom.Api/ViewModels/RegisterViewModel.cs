using System.ComponentModel.DataAnnotations;

namespace StudyRoom.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First Name Cannot be Longer Than 50 Characters.")]
        public string FirstName { get; set; } = null!;


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Last Name Cannot be Longer Than 50 Characters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; } = null!;

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "PhoneNumber is Required")]
        [Phone(ErrorMessage = "Please enter a valid Phone number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password Must be 8 Characters or Longer.")]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Must Match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}