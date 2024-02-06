using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using StudentsCrud.Controllers;

namespace StudentsCrud.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : StudentsCrudControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
