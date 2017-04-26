using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeReview_Ajax.Controllers
{

    /*
     Questions: 
     -(~X) Getting js to load on the page ?!?
     - (X)  append & html, what are the references, ( how to add stuff to the DOM)
     - Data flow of what exactly, (X) when things execute, and (x) if we have 2 js files....
         - (X) document.ready()
     -  randomizer
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