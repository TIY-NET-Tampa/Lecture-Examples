using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_TIYGift.Controllers
{
    /*
     Questions:
     - X how do I not forget to do something ( HINT: milage & reading the error message)
     - X What goes in the Models
     - X Data flow - How does data flow from controller to view to model back to the view????
        - why to have have a GET & POST to do an Update
     - X How to wire buttons to do stuff
     - How to work with create & Edit layouts when creating a view -- how to refernce what was inputted 
     - using the templates -- more how to tweak the HTML side of things 
     - many issues with id -- edit/Update how does that affect 
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