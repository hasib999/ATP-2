using Data_Passing_Techniques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_Passing_Techniques.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        //Data Passing Techniques C->V
        //1. Session
        //2. ViewData
        //3. ViewBag
        //4. TempData
        //5. Model(ViewModel,DataModel)

        [HttpGet]
        public ActionResult Index()
        {
            //TempData["name"] = "Nasir";
            //return RedirectToAction("Another");

            //if (Request.HttpMethod == "GET")
            //{
            //    return View();
            //}
            //else
            //{
            //    string username = Request["username"];
            //    return Content("<h2>Welcome, "+username+"</h2>");
            //}

            return View();
            
        }
        //Form Data Access
        //1.Request
        //2.FormCollection
        //3.Parameters
        //4.Model Binding

        [HttpPost]
        //public ActionResult FormProcess(FormCollection fc)
        //{
        //    //string username = Request["username"].ToString();
        //    string username = fc["username"].ToString();
        //    return Content(username);
        //}
        //public ActionResult FormProcess(string username,int PassWord)
        //{
        //    return Content(username+"->"+PassWord);
        //}
        public ActionResult Index(Person p,Other o)//model binding
        {
            //return Content(p.Username + "->" + p.Password + "->" + p.Hobby + "->" + o.Hobby);
            TempData["person"] = p;
            return RedirectToAction("F1");
        }

        public ActionResult F1()
        {
            Person p = TempData["person"] as Person;
            return View(p);
        }
        //public ActionResult F1()
        //{
        //    return Content(Request["username"].ToString());
        //}

        //public ActionResult Another()
        //{

        //    //Person p = new Person() { Name="Tamim",Email="tamim@gmail.com"};
        //    //Session["name"] = "Shakib";
        //    //Session["email"] = "shakib@gmail.com";
        //    //ViewData["name"] = "Tamim";
        //    //ViewBag.abc = "Mushfiq";

        //    return View();
        //}

        //public ActionResult Another2()
        //{
        //    return View("Another");
        //}
    }
}