using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Smart.AIMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AIMSControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}