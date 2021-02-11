using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using InventoryMVC.Models;
using InventoryMVC.Class;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace InventoryMVC.Class
{
    public class UserAction
    {
        public async Task<string> ValidateUser(string username, string password)
        {
            //return Task.Run(() =>
            //{
            //    try
            //    {
            //        Users user = new Users
            //        {
            //            username = username,
            //            password = password
            //        };
            //        string url = ApiUrl.apiUrl() + "account/validateuser";
            //        string json = JsonConvert.SerializeObject(user);
            //        using (var client = new WebClient())
            //        {
            //            client.Headers.Add("content-type", "application/json");
            //            var response = Encoding.ASCII.GetString(client.UploadData(url, "POST", Encoding.UTF8.GetBytes(json)));
            //        }
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //});
        }
    }
}