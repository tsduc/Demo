using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            MyModel myobj = new MyModel();
            myobj.NAME = "Thu vien lap trinh";
            myobj.PHONE = "123456";
            ViewBag.Message = "Your application description page." + id;

            return View(myobj);
        }

        public ActionResult Contact(string hello)
        {
            ViewBag.Message = "Your contact page. " + hello;

            return View();
        }
    }
}