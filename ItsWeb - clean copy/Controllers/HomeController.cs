using ItsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace ItsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            return RedirectToAction("Index", "Issue");
            /*
            if (ModelState.IsValid && WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
            {
                return Redirect("");
            }

            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
             * */
        }
    }
}
