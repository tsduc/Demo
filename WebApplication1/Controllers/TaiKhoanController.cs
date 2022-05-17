using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TaiKhoanController : Controller
    {
        // GET: TaiKhoan
        public ActionResult DangNhap(string thongBao)
        {
            ViewBag.thongbao = thongBao;
            return View();
        }

        // Action don du lieu
        [HttpGet]
        public ActionResult DangNhapHeThong(string tenDangNhap, string matKhau)
        {
            // Kiem tra ten dang nhap va mat khau
            // Neu tai khoan la: tsduc va pass la: 123456
            TempData["tendangnhap"] = tenDangNhap;
            TempData["matkhau"] = matKhau;
            if (tenDangNhap == "tsduc" && matKhau == "123456")
            {
                
                //Chuyen huong sang thong tin tai khoan
                //1. Chuyen huong theo action trong cung controller
                //return RedirectToAction("ThongTinTaiKhoan", new { ten = "Duc", sdt = 123456})

                //2. chuyen huong bang url
                return Redirect("/TaiKhoan/ThongTinTaiKhoan?ten=tsduc&sdt=123456");
            }

            return RedirectToAction("DangNhap", new { thongBao = "Ten dang nhap hoac mat khau khong dung"});
        }

        public ActionResult ThongTinTaiKhoan(string ten, int sdt)
        {
            return View();
        }


    }
}