using Abp.Authorization;
using PushDeck.Authorization.Roles;
using PushDeck.Authorization.Users;

namespace PushDeck.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
