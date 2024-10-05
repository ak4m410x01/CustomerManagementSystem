using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using CustomerManagementSystem.MVC.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementSystem.MVC.Controllers
{
    public class AccountController : Controller
    {
        #region Properties

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        #endregion Properties

        #region Constructors

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #endregion Constructors

        #region Methods

        public IActionResult Index()
        {
            return View();
        }

        // GET: Account/Login
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Customer");
                    }
                }

                ViewBag.Message = "Invalid Username or Password.";
            }

            return View(model);
        }

        // GET: Account/Register
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Create a new user instance
                var user = new ApplicationUser { UserName = model.Username };

                // Try to create the user in the database
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // If user is successfully created, sign them in
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Customer");
                }

                // If user creation fails, display errors
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        // GET: Account/Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        #endregion Methods
    }
}