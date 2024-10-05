using System.Runtime.Serialization;

namespace CustomerManagementSystem.MVC.Domain.Enumerations.Users
{
    public enum UserRoles
    {
        [EnumMember(Value = "Customer")]
        Customer,

        [EnumMember(Value = "Admin")]
        Admin,
    }
}