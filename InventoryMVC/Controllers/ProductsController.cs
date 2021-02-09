using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryMVC.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public ActionResult AddProducts()
        {
            TempData["RegisterImage"] = "https://tonsmb.org/wp-content/uploads/2014/03/default-placeholder.png";
            return View();
        }

        [HttpPost]
        public ActionResult AddProducts(FormCollection form)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Brands()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Brands(FormCollection form)
        {
            return View();
        }

    }
}