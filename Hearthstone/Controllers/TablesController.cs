using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class TablesController : Controller
    {
        [ActionName("BasicTables")]
        public ActionResult BasicTables()
        {
            return View();
        }

        [ActionName("GridJs")]
        public ActionResult GridJs()
        {
            return View();
        }

        [ActionName("ListJs")]
        public ActionResult ListJs()
        {
            return View();
        }

        [ActionName("Datatables")]
        public ActionResult Datatables()
        {
            return View();
        }
    }
}
