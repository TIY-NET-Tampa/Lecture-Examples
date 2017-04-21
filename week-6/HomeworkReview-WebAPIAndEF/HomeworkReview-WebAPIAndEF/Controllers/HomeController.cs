using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_WebAPIAndEF.Controllers
{
    /*
     Questions:
     - X how to work with Dates and seed Data
     - Mulitple VERBS (Best practice)???
    - Response Type & Swagger(Swashbuckle)
     - "That line" in the PUT
         */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
