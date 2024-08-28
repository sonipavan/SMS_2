﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_2.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View(); 
        }

        public ActionResult ServerError()
        {
            Response.StatusCode = 500;
            return View();
        }

    }
}