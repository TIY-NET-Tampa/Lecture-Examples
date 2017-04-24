using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_Reddit.Controllers
{

    /*
     Questions: 
     - Up/Down Button
     - how to get one user to onyl have 1 upvote -- new model???
     - homepage viewmodel  - iterating over the list of post 
        - yuuuge problem 
        - type error?
     - Metadata error ????
     - X API vs Non-API
     - Level 3?
     - My workflow for scafolding error with errors that 
     - change a background color of the site
     - relative datetime (1 hour ago, 2 hr ago) 
          
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