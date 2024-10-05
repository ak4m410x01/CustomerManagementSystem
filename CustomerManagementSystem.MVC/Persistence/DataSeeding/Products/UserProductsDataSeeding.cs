using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks;
using CustomerManagementSystem.MVC.Domain.Entities;
using CustomerManagementSystem.MVC.Domain.Enumerations.Users;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.MVC.Persistence.DataSeeding.Products
{
    public static class UserProductsDataSeeding
    {
        public static async Task InitializeUserProductsAsync(this UserManager<ApplicationUser> userManager, IUnitOfWork unitOfWork, ISpecification<Product> specification)
        {
            var products = await (await unitOfWork.Repository<Product>().GetAllAsNoTrackingAsync(specification)).Select(p => p.Id).ToListAsync();

            var users = await userManager.GetUsersInRoleAsync(nameof(UserRoles.Customer));

            var userProducts = new List<UserProduct>();
            foreach (var user in users)
            {
                int loops = Random.Shared.Next(1, 8);

                for (int i = 1; i <= loops; i++)
                {
                    var productId = Random.Shared.Next(1, products.Count);
                    while (userProducts.Any(i => i.UserId == user.Id && i.ProductId == productId))
                    {
                        productId = Random.Shared.Next(1, products.Count);
                    }

                    userProducts.Add(new UserProduct()
                    {
                        UserId = user.Id,
                        ProductId = productId,
                    });
                }
            }

            await unitOfWork.Repository<UserProduct>().AddRangeAsync(userProducts);
        }
    }
}