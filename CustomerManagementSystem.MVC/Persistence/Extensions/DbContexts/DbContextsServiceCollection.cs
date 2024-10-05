using CustomerManagementSystem.MVC.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.MVC.Persistence.Extensions.DbContexts
{
    public static class DbContextsServiceCollection
    {
        public static IServiceCollection AddDbContextsConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLbsneeDbContextConfiguration(configuration);

            return services;
        }

        private static IServiceCollection AddLbsneeDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            // Get Connection String From appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
                                       throw new InvalidOperationException("Connection string 'DefaultConnection' is missing.");

            // Add Application Db Context
            services.AddDbContext<CustomerManagementSystemDbContext>(options =>
            {
                options.UseLazyLoadingProxies()
                       .UseSqlServer(connectionString, builder =>
                       {
                           builder.MigrationsAssembly(typeof(CustomerManagementSystemDbContext).Assembly.FullName);
                       });
            });
            return services;
        }
    }
}