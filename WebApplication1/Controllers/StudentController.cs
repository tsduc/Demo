using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult createStudent(string std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            string message = "THÀNH CÔNG";
            return Json(new { Message = message, JsonRequestBehavior.AllowGet });
        }

        public JsonResult getStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
    }
}