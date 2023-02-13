using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class ProjectsController : Controller
    {

        [ActionName("List")]
        public ActionResult List()
        {
            return View();
        }

        [ActionName("Overview")]
        public ActionResult Overview()
        {
            return View();
        }

        [ActionName("CreateProject")]
        public ActionResult CreateProject()
        {
            return View();
        }

    }
}
