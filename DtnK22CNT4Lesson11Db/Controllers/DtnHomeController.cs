using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DtnK22CNT4Lesson11Db.Controllers
{
    public class DtnHomeController : Controller
    {
        public ActionResult DtnIndex()
        {
            return View();
        }

        public ActionResult DtnAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DtnContact()
        {
            ViewBag.msv = "2210900052";
            ViewBag.fullname = "Đặng Tài Nguyên";

            return View();
        }
    }
}