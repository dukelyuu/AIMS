using System.Web.Mvc;

namespace Smart.AIMS.Web.Controllers
{
    public class HomeController : AIMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}