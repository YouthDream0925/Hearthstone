using System.Linq;
using System.Web.Mvc;
using Hearthstone.Models;
using System.Data.SqlClient;
using System.Data;

namespace Hearthstone.Controllers
{
    public class MemberController : Controller
    {

        [ActionName("Statistics")]
        public ActionResult Statistics()
        {
            return View();
        }

        [ActionName("Properties")]
        public ActionResult Properties()
        {
            using (var entities = new HSEntities()) {

                var properties = entities.Properties.Include("Residents").ToList();

                return View(properties);
            }
        }

        [ActionName("Residents")]
        public ActionResult Residents()
        {
            using (var entities = new HSEntities())
            {

                var residents = entities.Residents.ToList();

                return View(residents);
            }
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
