using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using lessoon04dtn.Models;

namespace lessoon04dtn.Controllers
{
    public class DTNcustomerscaffdingController : Controller
    {
        private static List<DTNcustomer> Listcustomer = new List<DTNcustomer>()
            {
             new DTNcustomer()
                {
                    CustomerId = 1,
                    FirstName = "Dang Tai",
                    LastName = "Nguyen",
                    Address = "k22cnt4",
                    YearOfBirth = 2004

                },
             new DTNcustomer()
                {
                    CustomerId = 2,
                    FirstName = "Dam Vinh",
                    LastName = "trinh",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
            new DTNcustomer()
                {
                    CustomerId = 3,
                    FirstName = "Dam Vinh 1",
                    LastName = "trinh",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
            new DTNcustomer()
                {
                    CustomerId = 4,
                    FirstName = "Dam Vinh 2",
                    LastName = "trinh",
                    Address = "k22cnt3",
                    YearOfBirth = 2004
                },
            };




        // GET: DTNcustomerscaffding
        public ActionResult Index()
        {
            return View(Listcustomer);
        }
        [HttpGet]
        public ActionResult DTNCreate()
        {
            var model = new DTNcustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult DTNCreate(DTNcustomer model)
        {

            Listcustomer.Add(model);

            return RedirectToAction("Index");
        }
        public ActionResult DTNEdit(int id)
        {
            var customer = Listcustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}