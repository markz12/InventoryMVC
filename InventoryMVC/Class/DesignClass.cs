using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryMVC.Class
{
    public class DesignClass
    {
        public static string AlertDesign(int code)
        {
            string alert = string.Empty;
            if (code.Equals(200) || code.Equals(100))
            {
                return "alert-success";
            }
            else if (code.Equals(401) || code.Equals(404))
            {
                return "alert-warning";
            }
            else if (code.Equals(400) || code.Equals(500))
            {
                return "alert-danger";
            }
            else
            {
                return "alert-info";
            }
        }

        public static string StandardMessage(int code)
        {
            string message = string.Empty;
            switch (code)
            {
                case 100:
                    message = "Continue";
                    break;
                case 200:
                    message = "Success";
                    break;
                case 201:
                    message = "Created";
                    break;
                case 202:
                    message = "Accepted";
                    break;
                case 300:
                    message = "Parameter is Null";
                    break;
                case 400:
                    message = "Bad Request";
                    break;
                case 401:
                    message = "UnAuthorized";
                    break;
                case 403:
                    message = "Forbidden";
                    break;
                case 404:
                    message = "No record found";
                    break;
                case 409:
                    message = "Duplicate";
                    break;
                case 500:
                    message = "Internal Server Error";
                    break;
                case 0:
                    message = "Query Error";
                    break;
                default:
                    message = "Unidentified";
                    break;
            }
            return message;
        }
    }
}