using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryMVC.Models
{
    public class IAction<T>
    {
        public int code { get; set; }
        public string message { get; set; }
        public T data { get; set;}
    }
}