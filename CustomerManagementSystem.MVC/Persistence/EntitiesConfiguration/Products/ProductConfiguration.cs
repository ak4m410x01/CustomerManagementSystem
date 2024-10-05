using CustomerManagementSystem.MVC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerManagementSystem.MVC.Persistence.EntitiesConfiguration.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Table Name Configuration
            builder.ToTable("Products");

            // Properties Configuration
            builder.Property(product => product.Name)
                   .IsRequired();

            builder.Property(product => product.Price)
                   .HasPrecision(15, 3)
                   .IsRequired();

            builder.Property(product => product.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(product => product.DeletedAt)
                   .IsRequired(false);

            builder.Property(product => product.IsDeleted)
                   .HasComputedColumnSql("CASE WHEN [DeletedAt] IS NOT NULL THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END");
        }
    }
}