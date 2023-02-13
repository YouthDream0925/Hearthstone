using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class MapsController : Controller
    {

        [ActionName("Google")]
        public ActionResult Google()
        {
            return View();
        }

        [ActionName("Vector")]
        public ActionResult Vector()
        {
            return View();
        }

        [ActionName("Leaflet")]
        public ActionResult Leaflet()
        {
            return View();
        }

    }
}
