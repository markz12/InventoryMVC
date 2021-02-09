using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Dashboard()
        {
            //Get Data
            return View();
        }

        [HttpPost]
        public ActionResult Dashboard(string data)
        {
            return View();
        }
    }
}