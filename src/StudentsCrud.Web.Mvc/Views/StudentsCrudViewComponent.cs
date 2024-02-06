using Abp.AspNetCore.Mvc.ViewComponents;

namespace StudentsCrud.Web.Views
{
    public abstract class StudentsCrudViewComponent : AbpViewComponent
    {
        protected StudentsCrudViewComponent()
        {
            LocalizationSourceName = StudentsCrudConsts.LocalizationSourceName;
        }
    }
}
