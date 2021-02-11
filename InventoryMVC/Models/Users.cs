using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryMVC.Models
{
    public class Users
    {
        public int uid { get; set; }
        public string fullname { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string status { get; set; } // active, inactive & deleted
        public string roles { get; set; } // admin, user & customer
        public string image { get; set; }
        public DateTime datecreated { get; set; }
        public DateTime dateupdated { get; set; }
    }
}