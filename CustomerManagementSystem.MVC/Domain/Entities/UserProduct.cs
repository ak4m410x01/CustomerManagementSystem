using CustomerManagementSystem.MVC.Domain.Common.Abstracts;
using CustomerManagementSystem.MVC.Domain.IdentityEntities;

namespace CustomerManagementSystem.MVC.Domain.Entities
{
    public class UserProduct : BaseEntity
    {
        #region Relationships

        public int UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        #endregion Relationships
    }
}