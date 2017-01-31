using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        
        //
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        //
        // GET: /Store/Browse?Products=Create New
        
        public string Browse(string Products)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Products = " + Products);

            return message;

        }

        //
        // GET: /Store/Details/5

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;


        }
    }
}