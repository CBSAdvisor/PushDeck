using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PushDeck.Controllers
{
    public abstract class PushDeckControllerBase: AbpController
    {
        protected PushDeckControllerBase()
        {
            LocalizationSourceName = PushDeckConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
