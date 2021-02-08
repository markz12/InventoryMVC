using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace InventoryMVC.Controllers
{
    public class AuthController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            //if (ModelState.IsValid)
            //{
            //    if (ValidateUser(user.Email, user.Password))
            //    {

            //        FormsAuthentication.SetAuthCookie(user.Email, false);
            //        return RedirectToAction("Index", "Members");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "");
            //    }
            //}
            return View();
        }

        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Login", "Auth");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection form)
        {
            return View();
        }
    }
}