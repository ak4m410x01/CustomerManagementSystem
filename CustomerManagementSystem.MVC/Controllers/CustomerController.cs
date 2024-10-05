using CustomerManagementSystem.MVC.Domain.Enumerations.Users;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using CustomerManagementSystem.MVC.Models.Customer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagementSystem.MVC.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        #region Properties

        private readonly UserManager<ApplicationUser> _userManager;

        #endregion Properties

        #region Constructors

        public CustomerController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        #endregion Constructors

        #region Methods

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            var customers = await _userManager.GetUsersInRoleAsync(nameof(UserRoles.Customer));
            var customerViewModels = customers.Select(c => new CustomerViewModel
            {
                Id = c.Id,
                Code = c.Code ?? string.Empty,
                CustomerName = c.Name ?? string.Empty,
                DateOfRegistration = c.CreatedAt,
                SelectedProductIds = c.Products?.Select(p => p.Id).ToList() ?? new List<int>()
            });

            var viewModel = new CustomerListViewModel { Customers = customerViewModels };
            return View(viewModel);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var customer = await _userManager.FindByIdAsync(id.ToString());
            if (customer == null)
            {
                return NotFound();
            }

            var customerViewModel = new CustomerDetailsViewModel
            {
                Id = customer.Id,
                Code = customer.Code ?? string.Empty,
                CustomerName = customer.Name ?? string.Empty,
                DateOfRegistration = customer.CreatedAt,
                Products = customer.Products!.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Product?.Name ?? string.Empty,
                    Price = p.Product?.Price ?? default,
                }).ToList()
            };

            return View(customerViewModel);
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        #endregion Methods
    }
}