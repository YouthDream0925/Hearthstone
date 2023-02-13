using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class DashBoardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Analytics")]
        public ActionResult Analytics()
        {
            return View();
        }

        [ActionName("CRM")]
        public ActionResult CRM()
        {
            return View();
        }

        [ActionName("Crypto")]
        public ActionResult Crypto()
        {
            return View();
        }

        [ActionName("Projects")]
        public ActionResult Projects()
        {
            return View();
        }

        [ActionName("NFT")]
        public ActionResult NFT()
        {
            return View();
        }

        [ActionName("Job")]
        public ActionResult Job()
        {
            return View();
        }

    }
}
