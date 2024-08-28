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
        [HttpGet]
        public ActionResult studentinsertUpdate()
        {
            //StudentDA student = new StudentDA();
            //List<Students> students2 = new List<Students>();

            //students2 = student.GetStudentRecords();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                //// Simulate inserting the student
                //student.StudentID = students.Count > 0 ? students.Max(s => s.StudentID) + 1 : 1;
                //students.Add(student);

                //// Optionally, you can return JSON if using AJAX for a more dynamic experience
                //return Json(new { success = true });
            }

            // If the model is invalid, return the form view with validation errors
            return View("studentinsertUpdate"); // Adjust this to fit your actual view structure
        }
    }
}