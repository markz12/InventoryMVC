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
        public async Task<ActionResult> AddProducts()
        {
            TempData["RegisterImage"] = "https://tonsmb.org/wp-content/uploads/2014/03/default-placeholder.png";
            ResponseAPI<categories> response = await products.GetCategory();
            ViewBag.Code = response.code;
            ViewBag["GetCategory"] = response.data;
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
            ViewBag.Code = response.code;
            ViewBag.GetBrandAlert = DesignClass.AlertDesign(response.code);
            ViewBag.GetBrandMessage = DesignClass.StandardMessage(response.code);
            ViewData["brands"] = response.data;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Brands(string brand)
        {
            ReturnData<int> response = await products.AddBrands(brand,User.Identity.Name);
            TempData["Alert"] = DesignClass.AlertDesign(response.code);
            TempData["Message"] = DesignClass.StandardMessage(response.code);
            return Redirect("Brands");
        }

        [HttpGet]
        public async Task<ActionResult> Category()
        {
            ResponseAPI<categories> response = await products.GetCategory();
            ViewBag.Code = response.code;
            ViewBag.GetBrandAlert = DesignClass.AlertDesign(response.code);
            ViewBag.GetBrandMessage = DesignClass.StandardMessage(response.code);
            ViewData["categories"] = response.data;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Category(string category)
        {
            ReturnData<int> response = await products.AddCategory(category,User.Identity.Name);
            TempData["Alert"] = DesignClass.AlertDesign(response.code);
            TempData["Message"] = DesignClass.StandardMessage(response.code);
            return Redirect("Category");
        }

        [HttpGet]
        public async Task<ActionResult> Products()
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