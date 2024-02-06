using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using StudentsCrud.Controllers;

namespace StudentsCrud.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : StudentsCrudControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
