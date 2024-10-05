using CustomerManagementSystem.MVC.Domain.Entities;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CustomerManagementSystem.MVC.Persistence.DbContexts
{
    public class CustomerManagementSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        #region Constructors

        public CustomerManagementSystemDbContext(DbContextOptions<CustomerManagementSystemDbContext> options) : base(options)
        {
        }

        #endregion Constructors

        #region DbSets

        public DbSet<Product> Products { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }

        #endregion DbSets

        #region Methods

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Identity Entities Configuration

            // Config Identity Tables Names
            builder.Entity<IdentityRole<int>>().ToTable("Roles");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");

            #endregion Identity Entities Configuration

            #region Assemblies Configuration

            // Apply Entities Configurations
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #endregion Assemblies Configuration
        }

        #endregion Methods
    }
}