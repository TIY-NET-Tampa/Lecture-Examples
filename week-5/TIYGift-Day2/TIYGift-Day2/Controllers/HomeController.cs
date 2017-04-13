using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TIYGift_Day2.Controllers
{
    /*
     Questions: 
     - Wiring up the Buttons for Opening a Gift
     - ActionLink Variations
     - How to tranfer data with the buttons to multiple Pages
     - go over the CSS (what css we are working)
        - Create a service layer that takes a connection string as paramter and createas and SQL connection ithe Ctor

         */


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
    }
}