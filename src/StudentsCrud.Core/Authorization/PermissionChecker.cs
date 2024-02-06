using Abp.Authorization;
using StudentsCrud.Authorization.Roles;
using StudentsCrud.Authorization.Users;

namespace StudentsCrud.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
