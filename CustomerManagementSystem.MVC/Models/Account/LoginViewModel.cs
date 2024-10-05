using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.MVC.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = default!;

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = default!;
    }
}