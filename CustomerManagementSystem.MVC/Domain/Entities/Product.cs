using CustomerManagementSystem.MVC.Domain.Common.Abstracts;

namespace CustomerManagementSystem.MVC.Domain.Entities
{
    public class Product : BaseEntity
    {
        #region Properties

        public string? Name { get; set; }
        public decimal Price { get; set; }

        #endregion Properties

        #region Relationships

        public virtual ICollection<UserProduct>? Users { get; set; }

        #endregion Relationships
    }
}