using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HemoController : Controller
    {
        // GET: Hemo
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            ProductEditModel obj = new ProductEditModel();

            return View(obj);
        }


        [HttpPost]
        public ActionResult Create(ProductEditModel model)
        {
            //string message = "";

            //if (ModelState.IsValid)
            //{
            //message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";

            //List<Student> studentList = new List<Student>();
            //studentList.Add(new Student() { StudentName = model.Name });
            //studentList.Add(new Student() { StudentName = model.Rate.ToString() });
            //studentList.Add(new Student() { StudentName = model.Rating.ToString() });

            //ViewData["students"] = model.Name;

            //    return View();

            //}

            var arlist = new List<ProductEditModel> ();

            if (ModelState.IsValid)
            {
                //ProductEditModel obj = new ProductEditModel();
                //obj.Name = model.Name;
                //obj.Rate = model.Rate;
                //obj.Rating = model.Rating;


                arlist.Add(model);


                ViewData["hh"] = arlist;

                return View();
            }
            else
            {
                return Index();
            }



            //else
            //{
            //    message = "Failed to create the product. Please try again";
            //}
            //return Content(message);
        }
    }


}