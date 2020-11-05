using Inventory_Management_System_with_ADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Management_System_with_ADO.Net.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            ProductDataAccess pda = new ProductDataAccess();
            return View(pda.GetAllProducts());
        }
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product pro)
        {
            ProductDataAccess pda = new ProductDataAccess();
            int i = pda.InsertProduct(pro);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}