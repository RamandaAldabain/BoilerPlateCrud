using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace StudentsCrud.Controllers
{
    public abstract class StudentsCrudControllerBase: AbpController
    {
        protected StudentsCrudControllerBase()
        {
            LocalizationSourceName = StudentsCrudConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
