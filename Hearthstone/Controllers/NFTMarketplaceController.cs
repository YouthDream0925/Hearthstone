using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class NFTmarketplaceController : Controller
    {

        [ActionName("Marketplace")]
        public ActionResult Marketplace()
        {
            return View();
        }

        [ActionName("ExploreNow")]
        public ActionResult ExploreNow()
        {
            return View();
        }

        [ActionName("LiveAuction")]
        public ActionResult LiveAuction()
        {
            return View();
        }

        [ActionName("ItemDetails")]
        public ActionResult ItemDetails()
        {
            return View();
        }

        [ActionName("Collections")]
        public ActionResult Collections()
        {
            return View();
        }

        [ActionName("Creators")]
        public ActionResult Creators()
        {
            return View();
        }

        [ActionName("Ranking")]
        public ActionResult Ranking()
        {
            return View();
        }

        [ActionName("WalletConnect")]
        public ActionResult WalletConnect()
        {
            return View();
        }

        [ActionName("CreateNFT")]
        public ActionResult CreateNFT()
        {
            return View();
        }


    }
}
