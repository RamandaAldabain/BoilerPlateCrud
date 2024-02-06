using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace StudentsCrud.Web.Views
{
    public abstract class StudentsCrudRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected StudentsCrudRazorPage()
        {
            LocalizationSourceName = StudentsCrudConsts.LocalizationSourceName;
        }
    }
}
