using CustomerManagementSystem.MVC.Domain.Enumerations.Users;
using Microsoft.AspNetCore.Identity;

namespace CustomerManagementSystem.MVC.Persistence.DataSeeding.Users
{
    public static class RolesDataSeeding
    {
        public static async Task InitializeRolesAsync(this RoleManager<IdentityRole<int>> roleManager)
        {
            foreach (string role in Enum.GetNames(typeof(UserRoles)))
            {
                await roleManager.CreateAsync(new IdentityRole<int>(role));
            }
        }
    }
}