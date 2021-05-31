using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        ecommerceEntities db = new ecommerceEntities();
        // GET: Category
        public ActionResult CategoryList()
        {
            var category = db.categories.ToList();
            return View(category);
        }
    }
}