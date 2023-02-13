using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class CryptoController : Controller
    {

        [ActionName("Transactions")]
        public ActionResult Transactions()
        {
            return View();
        }

        [ActionName("BuySell")]
        public ActionResult BuySell()
        {
            return View();
        }

        [ActionName("Orders")]
        public ActionResult Orders()
        {
            return View();
        }

        [ActionName("MyWallet")]
        public ActionResult MyWallet()
        {
            return View();
        }

        [ActionName("ICOList")]
        public ActionResult ICOList()
        {
            return View();
        }

        [ActionName("KYCApplication")]
        public ActionResult KYCApplication()
        {
            return View();
        }

    }
}
