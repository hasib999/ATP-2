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
        [HttpGet]
        public ActionResult Index()
        {
            /*if (Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                Session["name"] = Request["name"];
                Session["username"] = Request["username"];
                Session["password"] = Request["password"];
                Session["blood"] = Request["blood"];
                Session["gender"] = Request["gender"];
                Session["dob"] = Request["dob"];
                return RedirectToAction("Another");
            }*/
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person p) 
        {
            Session["name"] = p.name;
            Session["username"] = p.username;
            Session["password"] = p.password;
            Session["blood"] = p.blood;
            Session["gender"] = p.gender;
            Session["dob"] = p.dob;
            return RedirectToAction("Another");
        }
        public ActionResult Another()
        {
            return View();
        }
    }
}