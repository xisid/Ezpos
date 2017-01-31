using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       //
       // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "EZ POS is a company specializing in technology solutions that can aid" +
                              " entrepreneurs in their quest of managing and growing their business." +
                              " EZ POS faciliates companies through providing the tools necessary to" +
                              " control all aspects of their business. Tools available would include the Sales" +
                              " Screen, Inventory Management, and Real - Time Dashboard.EZ POS's main focus is" +
                              " helping businesses grow and increase revenues so that expansion will be possible" +
                              " in the near future. ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us by " + "Email: EZPOS@gmail.com " + "Phone : (000) 000-0000 " ; 

            return View();
        }

        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "admin", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }


    }
}