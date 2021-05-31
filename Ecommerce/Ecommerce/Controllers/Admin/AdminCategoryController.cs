using Ecommerce.Helpers;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers.Admin
{
    public class AdminCategoryController : Controller
    {
        ecommerceEntities db = new ecommerceEntities();
        // GET: AdminCategory
        public ActionResult Index()
        {
            return View(db.categories.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(category category)
        {
            try
            {
                db.categories.Add(category);
                db.SaveChanges();
                Flashbag.setMessage(true, "Category Created Successfully");
            }
            catch(Exception ex)
            {
                
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Delete(long id)
        {
            category olddata = db.categories.Find(id);
            db.categories.Remove(olddata);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(long id)
        {
            category category = db.categories.Find(id);
            if(category== null)
            {
                HttpNotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(category category)
        {
            category olddata = db.categories.Find(category.id);
            olddata.name = category.name;
            olddata.cat_slug = category.cat_slug;
            db.Entry(olddata).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}