using Code_First_with_Repository_Pattern.Models;
using Code_First_With_Repository_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_First_with_Repository_Pattern.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryRepository categoryRepository = new CategoryRepository();
        [HttpGet]
        public ActionResult Index()
        {
            return View(categoryRepository.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            categoryRepository.Insert(cat);
            return RedirectToAction("Index");
        }
    }
}