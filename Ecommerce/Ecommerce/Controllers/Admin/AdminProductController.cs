using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers.Admin
{
    public class AdminProductController : Controller
    {
        ecommerceEntities db = new ecommerceEntities();
        // GET: AdminProduct
        public ActionResult Index()
        {
            return View(db.products.ToList());
        }
    }
}