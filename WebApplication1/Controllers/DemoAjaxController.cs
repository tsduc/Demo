using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DemoAjaxController : Controller
    {
        // GET: DemoAjax

        [HttpGet]
        public ActionResult CreateAjax()
        {
            var model = new ProductModel();

            return View();
        }

        [HttpPost]
        public ActionResult CreateAjax(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                //Xử lý dữ liệu
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Product Id :" + model.Id + "</br/>");
                sb.Append("Product Name :" + model.Name + "</br/>");
                sb.Append("Price :" + model.Price + "</br/>");
                return Content(sb.ToString());
            }
            else
            {
                return View(model);
            }
        }


        
        public ActionResult CreateHtml()
        {
            var model = new ProductModel();
            return View(model);
        }


        [HttpPost]
        public ActionResult CreateHtml(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                //Thực hiện xử lý dữ liệu 
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Product Id :" + model.Id + "</br/>");
                sb.Append("Product Name :" + model.Name + "</br/>");
                sb.Append("Price :" + model.Price + "</br/>");
                return Content(sb.ToString());
            }
            else
            {
                return View(model);
            }
        }
    }
}