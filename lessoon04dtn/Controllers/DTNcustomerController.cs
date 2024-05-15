using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lessoon04dtn.Models;

namespace lessoon04dtn.Controllers
{
    public class DTNcustomerController : Controller
    {
        // GET: DTNcustomer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DTNcustomerDetail()
        {
            var customer = new DTNcustomer()
            {
                CustomerId = 1,
                FirstName = "Dang Tai",
                LastName = "Nguyen",
                Address = "k22cnt4",
                YearOfBirth = 2004

            };
            ViewBag.customer = customer;
            return View();

        }
        public ActionResult DTNListcustomer()
        {
            var list = new List<DTNcustomer>()
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
                 CustomerId= 2,
                 FirstName= "Dam Vinh",
                 LastName="trinh",
                 Address= "k22cnt3",
                 YearOfBirth = 2004
            },
            new DTNcustomer()
             {
                 CustomerId= 3,
                 FirstName= "Dam Vinh 1",
                 LastName="trinh",
                 Address= "k22cnt3",
                 YearOfBirth = 2004
            },
            new DTNcustomer()
             {
                 CustomerId= 4,
                 FirstName= "Dam Vinh 2",
                 LastName="trinh",
                 Address= "k22cnt3",
                 YearOfBirth = 2004
            },
            };
            //ViewBag.list = list;//
            return View(list);
        }      
    }
}