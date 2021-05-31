using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class ProductController : Controller
    {
        ecommerceEntities db = new ecommerceEntities();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList(long id)
        {
            var productlist = db.products.Where(x => x.category_id == id).ToList();
            return View(productlist);
        }
        public ActionResult Product(long id)
        {
            var product = db.products.Find(id);
            ViewBag.prdName = product.name;
            ViewBag.photo = product.photo;
            ViewBag.Descrption = product.description;
            ViewBag.price = product.price;
            ViewBag.category= product.category.name;
            ViewBag.productid = product.id;
            return View();
        }
    }
}