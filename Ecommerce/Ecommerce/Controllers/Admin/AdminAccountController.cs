using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Models;
using System.Web.Security;
namespace Ecommerce.Controllers.Admin
{
    public class AdminAccountController : Controller
    {
        ecommerceEntities db = new ecommerceEntities();
        // GET: AdminAccount
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(user user)
        {
            bool isValid = db.users.Any(x => x.email == user.email && x.password == user.password);
            if(isValid)
            {
                FormsAuthentication.SetAuthCookie(user.email, false);
                RedirectToAction("CategoryList", "Category");
            }
            ModelState.AddModelError("", "Invalid Username and Password");
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(user user)
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}