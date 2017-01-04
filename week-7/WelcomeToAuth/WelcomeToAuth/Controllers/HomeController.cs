using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeToAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    if (User.IsInRole("admin"))
            //    {
            //        return View("AdminScreen");
            //    }
            //    else
            //    {
            //        return View("UserScreen");
            //    }
            //}
            //return View("MarketingPage");
            return View();

        }

        [Authorize]
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