using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.MVC.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = default!;

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = default!;
    }
}