using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Poc.WebApi.Models;

namespace Poc.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var custSearch = new CustomerSearch()
            {
                Id = "JKJK*"
            };
            string url = Request.Url.GetLeftPart(UriPartial.Authority) + Request.ApplicationPath + "api/Customer";
            string jsonData = JsonConvert.SerializeObject(custSearch);
            var req = HttpWebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            byte[] jsonByteData = ASCIIEncoding.ASCII.GetBytes(jsonData.ToCharArray());
            
            var reqStream = req.GetRequestStream();
            reqStream.Write(jsonByteData, 0, jsonData.Length);
            var response = req.GetResponse();
            var respStream = new StreamReader(response.GetResponseStream());

            string responseJsonData = respStream.ReadToEnd();
            Customer customer = JsonConvert.DeserializeObject<Customer>(responseJsonData);

            return View(customer);
        }
    }
}
