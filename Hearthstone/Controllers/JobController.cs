using System.Web.Mvc;

namespace Hearthstone.Controllers
{
    public class JobController : Controller
    {

        [ActionName("Statistics")]
        public ActionResult Statistics()
        {
            return View();
        }

        [ActionName("Application")]
        public ActionResult Application()
        {
            return View();
        }

        [ActionName("NewJob")]
        public ActionResult NewJob()
        {
            return View();
        }

        [ActionName("CompaniesList")]
        public ActionResult CompaniesList()
        {
            return View();
        }

        [ActionName("JobCategories")]
        public ActionResult JobCategories()
        {
            return View();
        }

        [ActionName("List")]
        public ActionResult List()
        {
            return View();
        }

        [ActionName("Grid")]
        public ActionResult Grid()
        {
            return View();
        }

        [ActionName("Overview")]
        public ActionResult Overview()
        {
            return View();
        }

        [ActionName("ListView")]
        public ActionResult ListView()
        {
            return View();
        }

        [ActionName("GridView")]
        public ActionResult GridView()
        {
            return View();
        }
    }
}
