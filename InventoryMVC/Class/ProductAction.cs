using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryMVC.Models;
using Newtonsoft.Json;
using InventoryMVC.Class;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;

namespace InventoryMVC.Class
{
    public class ProductAction
    {
        public async Task<ResponseAPI<brands>> GetBrands()
        {
            ResponseAPI<brands> res = new ResponseAPI<brands>();
            try
            {
                string url = ApiUrl.apiUrl() + "products/getbrand?status=" + "active";
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var resp = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ResponseAPI<brands>>(resp);
                }
            }
            catch (Exception ex)
            {
                res = new ResponseAPI<brands>
                {
                    code = 500,
                    message = ex.Message,
                    data = null
                };
                return res;
            }
        }

        public async Task<ReturnData<int>> AddBrands(string brnd, string createdby)
        {
            return await Task.Run(() =>
            {
                try
                {
                    brands brand = new brands
                    {
                        name = brnd,
                        createdby = createdby
                    };
                    string url = ApiUrl.apiUrl() + "products/addbrand";
                    string json = JsonConvert.SerializeObject(brand);
                    using (var client = new WebClient())
                    {
                        client.Headers.Add("content-type", "application/json");
                        var response = Encoding.ASCII.GetString(client.UploadData(url, "POST", Encoding.UTF8.GetBytes(json)));
                        return JsonConvert.DeserializeObject<ReturnData<int>>(response);
                    }
                }
                catch (Exception ex)
                {
                    ReturnData<int> err = new ReturnData<int>
                    {
                        code = 500,
                        message = ex.Message
                    };
                    return err;
                }
            });
        }
    }
}