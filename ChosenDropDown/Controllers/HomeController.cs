using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChosenDropDown.Models;

namespace ChosenDropDown.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChosenDropDown()
        {
            DBModels db = new DBModels();
            Customers objCustumer = new Customers();
            objCustumer.GetCustomerList = db.Tbl_Customer.Select(x => new Customers
            {
                CustomerId = x.Id,
                CustomerName = x.Name
            }).ToList();
            return View(objCustumer);
        }

        [HttpPost]
        public ActionResult ChosenDropDown(Customers objCustomer)
        {
            //Save Selected Item into table
            return RedirectToAction("ChosenDropDown");
        }

    }
}