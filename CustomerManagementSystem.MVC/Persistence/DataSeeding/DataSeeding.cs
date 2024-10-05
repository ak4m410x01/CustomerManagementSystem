using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks;
using CustomerManagementSystem.MVC.Domain.Entities;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using CustomerManagementSystem.MVC.Persistence.DataSeeding.Products;
using CustomerManagementSystem.MVC.Persistence.DataSeeding.Users;
using CustomerManagementSystem.MVC.Persistence.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.MVC.Persistence.DataSeeding
{
    public static class DataSeeding
    {
        public static async Task Initialize(IServiceProvider services)
        {
            var context = services.GetService<CustomerManagementSystemDbContext>();
            if (context == null)
                return;

            var isPendingMigrations = (await context.Database.GetPendingMigrationsAsync()).Any();
            if (isPendingMigrations)
            {
                await context.Database.MigrateAsync();

                await services.InitializeRolesDataAsync();
                await services.InitializeUsersDataAsync();
                await services.InitializeProductsDataAsync();
                await services.InitializeUserProductsDataAsync();
            }
        }

        private static async Task InitializeRolesDataAsync(this IServiceProvider services)
        {
            var roleManager = services.GetService<RoleManager<IdentityRole<int>>>();

            if (roleManager is null)
                return;

            await roleManager.InitializeRolesAsync();
        }

        private static async Task InitializeUsersDataAsync(this IServiceProvider services)
        {
            var userManager = services.GetService<UserManager<ApplicationUser>>();

            if (userManager is null)
                return;

            await userManager.InitializeUsersAsync();
        }

        private static async Task InitializeProductsDataAsync(this IServiceProvider services)
        {
            var unitOfWork = services.GetService<IUnitOfWork>();

            if (unitOfWork is null)
                return;

            await unitOfWork.InitializeProductsAsync();
        }

        private static async Task InitializeUserProductsDataAsync(this IServiceProvider services)
        {
            var userManager = services.GetService<UserManager<ApplicationUser>>();
            var unitOfWork = services.GetService<IUnitOfWork>();
            var specification = services.GetService<ISpecification<Product>>();

            if (userManager is null || unitOfWork is null || specification is null)
                return;

            await userManager.InitializeUserProductsAsync(unitOfWork, specification);
        }
    }
}