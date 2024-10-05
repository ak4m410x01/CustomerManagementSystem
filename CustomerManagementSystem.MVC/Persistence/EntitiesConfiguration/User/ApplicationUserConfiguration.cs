using CustomerManagementSystem.MVC.Domain.IdentityEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.MVC.Persistence.EntitiesConfiguration.User
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Table Name Configuration
            builder.ToTable("Users");

            // Properties Configuration
            builder.Property(user => user.UserName)
                   .IsRequired();

            builder.Property(user => user.PasswordHash)
                   .IsRequired();

            builder.Property(user => user.Name)
                   .IsRequired(false);

            builder.Property(user => user.Code)
                   .IsRequired(false);

            builder.Property(user => user.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(user => user.DeletedAt)
                   .IsRequired(false);

            builder.Property(user => user.IsDeleted)
                   .HasComputedColumnSql("CASE WHEN [DeletedAt] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END");
        }

        #endregion Methods
    }
}