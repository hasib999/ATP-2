using Inventory_Management_System_with_ADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Management_System_with_ADO.Net.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            return View(cda.GetAllCategories());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category cat)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            int i=cda.InsertCategory(cat);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            return View(cda.GetCategoryById(id));
        }
        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            int i = cda.UpdateCategory(cat);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            return View(cda.GetCategoryById(id));
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            CategoryDataAccess cda = new CategoryDataAccess();
            int i = cda.DeleteCategory(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}