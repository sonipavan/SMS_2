using DA.DA;
using SMS_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS_2.Controllers
{
    public class StudentController : Controller
    {
      
        // GET: Student
        [HttpGet]
        public ActionResult ViewStudent()
        {
            StudentDA student = new StudentDA();
            List<Students> students = new List<Students>();

            students = student.GetStudentRecords();            
            return View("ViewS", students);
        }
    }
}