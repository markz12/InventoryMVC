using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using InventoryMVC.Class;
using InventoryMVC.Models;
using Newtonsoft.Json;

namespace InventoryMVC.Controllers
{
    [Authorize]
    public class AuthController : Controller
    {
        UserAction UserAction = new UserAction();
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(FormCollection form)
        {
            var response = JsonConvert.DeserializeObject<IAction<Users>>(UserAction.ValidateUser(form["username"], form["password"]));
            return RedirectToAction("Dashboard","Home");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logout(string loginUrl)
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
            TempData["RegisterImage"] = "https://tonsmb.org/wp-content/uploads/2014/03/default-placeholder.png";
            return View();
        }

        [HttpPost]
        public ActionResult Register(FormCollection form)
        {
            return View();
        }
    }
}