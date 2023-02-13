using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class EcommerceController : Controller
    {

        [ActionName("Products")]
        public ActionResult Products()
        {
            return View();
        }

        [ActionName("ProductDetails")]
        public ActionResult ProductDetails()
        {
            return View();
        }

        [ActionName("CreateProduct")]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [ActionName("Orders")]
        public ActionResult Orders()
        {
            return View();
        }

        [ActionName("OrderDetails")]
        public ActionResult OrderDetails()
        {
            return View();
        }

        [ActionName("Customers")]
        public ActionResult Customers()
        {
            return View();
        }

        [ActionName("ShoppingCart")]
        public ActionResult ShoppingCart()
        {
            return View();
        }

        [ActionName("Checkout")]
        public ActionResult Checkout()
        {
            return View();
        }

        [ActionName("Sellers")]
        public ActionResult Sellers()
        {
            return View();
        }

        [ActionName("SellerDetails")]
        public ActionResult SellerDetails()
        {
            return View();
        }

    }
}
