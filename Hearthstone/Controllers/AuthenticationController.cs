using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hearthstone.Controllers
{
    public class AuthenticationController : Controller
    {

        [ActionName("SignInBasic")]
        public ActionResult SignInBasic()
        {
            return View();
        }

        [ActionName("SignInCover")]
        public ActionResult SignInCover()
        {
            return View();
        }

        [ActionName("SignUpBasic")]
        public ActionResult SignUpBasic()
        {
            return View();
        }

        [ActionName("SignUpCover")]
        public ActionResult SignUpCover()
        {
            return View();
        }

        [ActionName("PasswordResetBasic")]
        public ActionResult PasswordResetBasic()
        {
            return View();
        }

        [ActionName("PasswordResetCover")]
        public ActionResult PasswordResetCover()
        {
            return View();
        }

        [ActionName("PasswordChangeBasic")]
        public ActionResult PasswordChangeBasic()
        {
            return View();
        }

        [ActionName("PasswordChangeCover")]
        public ActionResult PasswordChangeCover()
        {
            return View();
        }

        [ActionName("LockScreenBasic")]
        public ActionResult LockScreenBasic()
        {
            return View();
        }

        [ActionName("LockScreenCover")]
        public ActionResult LockScreenCover()
        {
            return View();
        }

        [ActionName("LogoutBasic")]
        public ActionResult LogoutBasic()
        {
            return View();
        }

        [ActionName("LogoutCover")]
        public ActionResult LogoutCover()
        {
            return View();
        }

        [ActionName("SuccessMessageBasic")]
        public ActionResult SuccessMessageBasic()
        {
            return View();
        }

        [ActionName("SuccessMessageCover")]
        public ActionResult SuccessMessageCover()
        {
            return View();
        }

        [ActionName("TwoStepVerificationBasic")]
        public ActionResult TwoStepVerificationBasic()
        {
            return View();
        }

        [ActionName("TwoStepVerificationCover")]
        public ActionResult TwoStepVerificationCover()
        {
            return View();
        }

        [ActionName("Errors404Basic")]
        public ActionResult Errors404Basic()
        {
            return View();
        }

        [ActionName("Errors404Cover")]
        public ActionResult Errors404Cover()
        {
            return View();
        }

        [ActionName("Errors404Alt")]
        public ActionResult Errors404Alt()
        {
            return View();
        }

        [ActionName("Errors500")]
        public ActionResult Errors500()
        {
            return View();
        }

        [ActionName("Offline")]
        public ActionResult Offline()
        {
            return View();
        }

    }
}
