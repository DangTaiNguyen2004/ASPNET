using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dtn.leson03.Controllers
{
    /// <summary>
    /// Author: Đặng tài Nguyên 
    /// Class: k22cnt4
    /// </summary>
    public class DTNk22cnt4Controller : Controller
    {
        // GET: DTNk22cnt4
        public ActionResult Index()
        {
            ViewBag.fullname = "Đặng Tài Nguyên";
            ViewData["birthday"] = "14/11/2004";
            TempData["phone"] = "0963332145";
            return View();
        }
        public ActionResult Details(){
            String DtnStr = "";
            DtnStr += "<h3>ho va ten: dang tai nguyen</h3>";
            DtnStr += "<p>ma so: 2210900052";
            DtnStr += "<p> dai chi mail : nguyendang@gmail.com";
            ViewBag.Details = DtnStr;

            return View("chitiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "tran van a", "nguyen thi b", "le dai c", "trinh van D" };
            ViewBag.names = names;
            return View();
        }

        public ActionResult AddnewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddnewStudent(FormCollection form)
        {
            string fullname = form["fullname"];
            string masv = form["MaSV"];
            string taikhoan = form["taikhoan"];
            string matkhau = form["matkhau"];

            string DtnStr = "<h3>" + fullname + "</h3>";
            DtnStr += "<p>" + masv;
            DtnStr += "<p>" + taikhoan;
            DtnStr += "<p>" + matkhau;

            ViewBag.info = DtnStr;

            return View("Ketqua");
        }


    }
}