using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace InventoryMVC.Class
{
    public class ApiUrl
    {
        public static string apiUrl()
        {
            return ConfigurationManager.AppSettings["apiUrl"].ToString();
        }
    }
}