using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryMVC.Controllers
{
    public class ReportsController : Controller
    {
        [HttpGet]
        public ActionResult Reports()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reports(string data)
        {
            return View();
        }
    }
}