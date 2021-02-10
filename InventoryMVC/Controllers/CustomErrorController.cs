using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryMVC.Controllers
{
    [HandleError]
    public class CustomErrorController : Controller
    {
        public ActionResult Unauthorized()
        {
            Response.StatusCode = 401;
            return View();
        }
        public ActionResult PageNotFound()
        {
            Response.StatusCode = 404;
            return View();
        }
        public ActionResult InternalServerError()
        {
            Response.StatusCode = 500;
            return View();
        }
    }
}