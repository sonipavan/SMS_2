using DA.DA;
using SMS_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;


namespace SMS_2.Controllers
{
    [AllowAnonymous]
    public class registerController : Controller
    {
        // GET: register
        [HttpGet]
        public ActionResult register()
        {
            var register = new register
            {
                Gender = new List<SelectListItem>
                {
                    new SelectListItem{Value="1",Text="Male"},
                    new SelectListItem{Value="2",Text="Female"}
                }
            };
            return View(register);
        }
        [HttpPost]
        public ActionResult register(register register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RegisterDA registerDA = new RegisterDA();
                    string data = registerDA.SaveStudent(register.FirstName,register.LastName, register.DateOfBirth, register.Email, register.PhoneNumber, register.Address, register.Password);
                    register.Gender = new List<SelectListItem>
                    {
                    new SelectListItem{Value="1",Text="Male"},
                    new SelectListItem{Value="2",Text="Female"}
                    };
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "UserName is wrong");
                    register.Gender = new List<SelectListItem>
                    {
                    new SelectListItem{Value="1",Text="Male"},
                    new SelectListItem{Value="2",Text="Female"}
                    };
                }
                return View(register);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}