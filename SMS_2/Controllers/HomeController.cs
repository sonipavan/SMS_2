using DA.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SMS_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.Login login)
        {
            LoginDA loginda1 = new LoginDA();
            if (ModelState.IsValid)
            {
                if (loginda1.VerifyUser(login.Name, login.Password) == "Success")
                {
                    FormsAuthentication.SetAuthCookie(login.Name, false);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or password is wrong");
                }
            }
           
            return View();
        }
        //public ActionResult Dashboard()
        //{
        //    return View();
        //}
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}