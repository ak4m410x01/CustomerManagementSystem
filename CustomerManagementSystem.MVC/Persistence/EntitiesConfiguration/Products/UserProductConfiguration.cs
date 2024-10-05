using CustomerManagementSystem.MVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerManagementSystem.MVC.Persistence.EntitiesConfiguration.Products
{
    public class UserProductConfiguration : IEntityTypeConfiguration<UserProduct>
    {
        public void Configure(EntityTypeBuilder<UserProduct> builder)
        {
            // Table Name Configuration
            builder.ToTable("UserProducts");

            // Properties Configuration
            builder.Property(userProduct => userProduct.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(userProduct => userProduct.DeletedAt)
                   .IsRequired(false);

            builder.Property(userProduct => userProduct.IsDeleted)
                   .HasComputedColumnSql("CASE WHEN [DeletedAt] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END");

            // Relationships Configuration
            builder.HasOne(userProduct => userProduct.Product)
                   .WithMany(product => product.Users)
                   .HasForeignKey(userProduct => userProduct.ProductId)
                   .IsRequired();

            builder.HasOne(userProduct => userProduct.User)
                   .WithMany(user => user.Products)
                   .HasForeignKey(userProduct => userProduct.UserId)
                   .IsRequired();
        }
    }
}