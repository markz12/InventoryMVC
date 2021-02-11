using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryMVC.Class;
using InventoryMVC.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace InventoryMVC.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        ProductAction products = new ProductAction();
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
        public async Task<ActionResult> Brands()
        {
            ResponseAPI<brands> response = await products.GetBrands();
            ViewBag.GetBrandAlert = DesignClass.AlertDesign(response.code);
            ViewBag.GetBrandMessage = DesignClass.StandardMessage(response.code);
            ViewData["brands"] = response.data;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Brands(string brand)
        {
            ReturnData<int> response = await products.AddBrands(brand,User.Identity.Name);
            ViewBag.AddBrandAlert = DesignClass.AlertDesign(response.code);
            ViewBag.AddBrandMessage = DesignClass.StandardMessage(response.code);
            return View();
        }

        [HttpGet]
        public ActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Category(FormCollection form)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Products()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Products(FormCollection form)
        {
            return View();
        }
    }
}