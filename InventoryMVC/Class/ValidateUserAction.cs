using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryMVC.Class
{
    public class ValidateUserAction
    {
        //public static bool ValidateUser()
        //{
        //bool isValid = false;

        //using (var db = new ShareRideDBEntities())
        //{
        //    var User = db.tblProfiles.FirstOrDefault(u => u.PROF_Email == Email);
        //    var ut = db.tblProfilesTypes.FirstOrDefault(t => t.TPE_ID == User.PROF_UserType);

        //    if (User != null)
        //    {
        //        if (User.PROF_Password == Password)
        //        {
        //            Session["UserID"] = User.PROF_UserID;
        //            Session["Name"] = User.PROF_FirstName;
        //            Session["Email"] = User.PROF_Email;
        //            Session["FullName"] = User.PROF_FirstName + " " + User.PROF_LastName;

        //            isValid = true;
        //        }
        //    }

        //}

        //return isValid;
        //}

        //    string url = URL + "/post/" + refno;
        //    string json = JsonConvert.SerializeObject(Data);
        //            using (var client = new WebClient())
        //            {
        //                client.Headers.Add("content-type", "application/json");
        //                client.Headers.Add("Authorization", "Bearer " + token);
        //                return Encoding.ASCII.GetString(client.UploadData(url, "POST", Encoding.UTF8.GetBytes(json)));
        //            }
        //}

        //Uri uri = new Uri(string.Format(URL + "inquire/" + refNo));
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

        //request.Method = "GET";
        //        request.ProtocolVersion = HttpVersion.Version11;
        //        request.Headers.Add("Authorization", "Bearer " + token);
        //        request.ContentType = "application/json";
        //        request.ServerCertificateValidationCallback = delegate { return true; };

        //        using (var rsps = new StreamReader(request.GetResponse().GetResponseStream()))
        //        {
        //            return rsps.ReadToEnd();
        //        }

        //Uri uri = new Uri(string.Format(API_URL.url_api() + "api/qweqw/qweqw/" + refNo + "/" + branchCode));
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

        //request.Method = "GET";
        //        request.ProtocolVersion = HttpVersion.Version11;
        //        request.ContentType = "application/json";
        //        request.ServerCertificateValidationCallback = delegate { return true; };

        //        using (var rsps = new StreamReader(request.GetResponse().GetResponseStream()))
        //        {
        //            return rsps.ReadToEnd();
        //        }
        //string url = API_URL.url_api() + "api/qwe/qwe";
        //string json = JsonConvert.SerializeObject(Data);
        //        using (var client = new WebClient())
        //        {
        //            client.Headers.Add("content-type", "application/json");
        //            return Encoding.ASCII.GetString(client.UploadData(url, "POST", Encoding.UTF8.GetBytes(json)));
        //        }


        //Uri uri = new Uri(string.Format(API_URL.url_api() + "api/qweqw/qweqw/{0}", bcode));
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

        //request.Method = "GET";
        //        request.ProtocolVersion = HttpVersion.Version11;
        //        request.ContentType = "application/json";
        //        request.ServerCertificateValidationCallback = delegate { return true; };

        //        using (var rsps = new StreamReader(request.GetResponse().GetResponseStream()))
        //        {
        //            return rsps.ReadToEnd();
        //        }


        //Uri uri = new Uri(string.Format(URL + "api/payout/v1/rdpawnshop/inquire/" + reference + ""));
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

        //request.Method = "GET";
        //        request.Headers.Add("Authorization", PayoutToken);
        //        request.ProtocolVersion = HttpVersion.Version11;
        //        request.ContentType = "application/json";
        //        request.ServerCertificateValidationCallback = delegate { return true; };//reader
        //        using (var reader = new StreamReader(request.GetResponse().GetResponseStream()))
        //        {
        //            return reader.ReadToEnd();
        //        }
}

}