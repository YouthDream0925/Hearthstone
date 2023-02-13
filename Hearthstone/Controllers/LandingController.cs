using System.Web.Mvc;

namespace Hearthstone.Controllers
{
    public class LandingController : Controller{
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NFTLanding()
        {
            return View();
        }

        public ActionResult Job()
        {
            return View();
        }

        [ActionName("PrivacyPolicy")]
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        [ActionName("TermConditions")]
        public ActionResult TermConditions()
        {
            return View();
        }
    }
}
