using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        ecommerceEntities db = new ecommerceEntities();
        public ActionResult Index()
        {
            var a = db.categories.ToList();
            var b = a;
            dynamic mymodel = new ExpandoObject();
            mymodel.Category = db.categories.ToList();
            ViewBag.CategoryList = new SelectList(db.categories.ToList(), "id", "name");
            return View(a);
        }
        public ActionResult navbar()
        {
            var a = db.categories.ToList();
            var b = a;
            dynamic mymodel = new ExpandoObject();
            mymodel.Category = db.categories.ToList();
            ViewBag.CategoryList = new SelectList(db.categories.ToList(), "id", "name");
            return View(a);
        }
    }
}