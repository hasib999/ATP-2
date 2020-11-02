using Scafolding_Technique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scafolding_Technique.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        List<Person> persons = new List<Person>() { 
            new Person() { id="1" , name="hasib" ,email="hasib@" , salary="20000"} ,
            new Person() { id="2" , name="hasib" ,email="hasib@" , salary="20000"} ,
            new Person() { id="3" , name="hasib" ,email="hasib@" , salary="20000"} ,
            new Person() { id="4" , name="hasib" ,email="hasib@" , salary="20000"} ,

        };
        public ActionResult Index()
        {
            return View(persons);
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Person p = persons.Where(x => x.id == id).First();
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(string id, Person p)
        {
            return RedirectToAction("Index");
        }
    }
}