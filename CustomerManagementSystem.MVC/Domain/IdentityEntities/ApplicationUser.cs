using CustomerManagementSystem.MVC.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CustomerManagementSystem.MVC.Domain.IdentityEntities
{
    public class ApplicationUser : IdentityUser<int>
    {
        #region Properties

        public string? Name { get; set; }
        public string? Code { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }

        #endregion Properties

        #region Relationships

        public virtual ICollection<UserProduct>? Products { get; set; }

        #endregion Relationships
    }
}