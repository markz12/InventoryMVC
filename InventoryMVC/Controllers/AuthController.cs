using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using InventoryMVC.Class;
using InventoryMVC.Models;
using Newtonsoft.Json;
using System.Configuration;

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
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Dashboard", "Home");
            }
            
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(string username,string password)
        {
            try
            {
                ReturnData<Users> response = await UserAction.ValidateUser(username, password);
                if (response.code == 200)
                {
                    Users user = response.data;
                    int CookiesExpire = int.Parse(ConfigurationManager.AppSettings["cookiesExpire"].ToString());
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(user.uid, user.username, DateTime.Now, DateTime.Now.AddMinutes(CookiesExpire), true, user.roles);
                    string cookieContents = FormsAuthentication.Encrypt(ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, cookieContents)
                    {
                        Expires = ticket.Expiration,
                        Path = FormsAuthentication.FormsCookiePath
                    };
                    Response.Cookies.Add(cookie);
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    ViewBag.ClassStatus = DesignClass.AlertDesign(response.code);
                    ViewBag.Message = response.message;
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ClassStatus = DesignClass.AlertDesign(500);
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
            cookie.Expires = DateTime.Now.AddYears(-1);
            Response.Cookies.Add(cookie);
            return RedirectToAction("Login", "Auth");
        }

        [HttpGet]
        [AllowAnonymous]
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