using System.Web.Mvc;

namespace Spyer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Info()
        {
            return PartialView();
        }
    }
}