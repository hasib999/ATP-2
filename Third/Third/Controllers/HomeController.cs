using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Third.Models;

namespace Third.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                
            }
            
        }

        public ActionResult Another()
        {
            return View();
        }
    }
}