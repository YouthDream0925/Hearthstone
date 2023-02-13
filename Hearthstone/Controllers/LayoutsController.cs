using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class LayoutsController : Controller
    {

        [ActionName("Horizontal")]
        public ActionResult Horizontal()
        {
            return View();
        }

        [ActionName("Detached")]
        public ActionResult Detached()
        {
            return View();
        }

        [ActionName("TwoColumn")]
        public ActionResult TwoColumn()
        {
            return View();
        }

        [ActionName("Hovered")]
        public ActionResult Hovered()
        {
            return View();
        }

    }
}
