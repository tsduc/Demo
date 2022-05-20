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

        [HttpGet]
        public ActionResult About()
        {
            MyModel myobj = new MyModel();
            

            return View(myobj);
        }

        [HttpPost]
        public ActionResult About(MyModel id)
        {
            MyModel myobj = new MyModel();
            myobj.NAME = id.NAME;
            myobj.PHONE = id.PHONE;
            ViewBag.Message = "Your application description page.";

            return View(myobj);
        }

        public ActionResult Contact(string hello)
        {
            ViewBag.Message = "Your contact page. " + hello;

            return View();
        }
    }
}