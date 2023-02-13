using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class FormsController : Controller
    {

        [ActionName("BasicElements")]
        public ActionResult BasicElements()
        {
            return View();
        }

        [ActionName("FormSelect")]
        public ActionResult FormSelect()
        {
            return View();
        }

        [ActionName("CheckboxsRadios")]
        public ActionResult CheckboxsRadios()
        {
            return View();
        }

        [ActionName("Pickers")]
        public ActionResult Pickers()
        {
            return View();
        }

        [ActionName("InputMasks")]
        public ActionResult InputMasks()
        {
            return View();
        }

        [ActionName("Advanced")]
        public ActionResult Advanced()
        {
            return View();
        }

        [ActionName("RangeSlider")]
        public ActionResult RangeSlider()
        {
            return View();
        }

        [ActionName("Validation")]
        public ActionResult Validation()
        {
            return View();
        }

        [ActionName("Wizard")]
        public ActionResult Wizard()
        {
            return View();
        }

        [ActionName("Editors")]
        public ActionResult Editors()
        {
            return View();
        }

        [ActionName("FileUploads")]
        public ActionResult FileUploads()
        {
            return View();
        }

        [ActionName("FormLayouts")]
        public ActionResult FormLayouts()
        {
            return View();
        }

        [ActionName("Select2")]
        public ActionResult Select2()
        {
            return View();
        }
    }
}
