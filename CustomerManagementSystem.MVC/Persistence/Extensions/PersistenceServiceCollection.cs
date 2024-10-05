using CustomerManagementSystem.MVC.Application.Interfaces.Repositories;
using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using CustomerManagementSystem.MVC.Persistence.DbContexts;
using CustomerManagementSystem.MVC.Persistence.Extensions.DbContexts;
using CustomerManagementSystem.MVC.Persistence.Repositories;
using CustomerManagementSystem.MVC.Persistence.Specifications;
using CustomerManagementSystem.MVC.Persistence.UnitOfWorks;
using Microsoft.AspNetCore.Identity;

namespace CustomerManagementSystem.MVC.Persistence.Extensions
{
    public static class PersistenceServiceCollection
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextsConfiguration(configuration);

            // Identity Entities Configuration
            services.AddIdentity<ApplicationUser, IdentityRole<int>>()
                    .AddUserManager<UserManager<ApplicationUser>>()
                    .AddRoleManager<RoleManager<IdentityRole<int>>>()
                    .AddEntityFrameworkStores<CustomerManagementSystemDbContext>()
                    .AddDefaultTokenProviders();

            // Specification Configuration
            services.AddScoped(typeof(ISpecification<>), typeof(Specification<>));

            // Repository Configuration
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // UnitOfWork Configuration
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}