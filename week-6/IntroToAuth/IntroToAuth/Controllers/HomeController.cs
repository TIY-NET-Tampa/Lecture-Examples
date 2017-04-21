using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var name = HttpContext.User.Identity.Name;
                var userId = User.Identity.GetUserId();
            }

            return View();
        }

        [Authorize]
        public ActionResult Club()
        {
            return View();
        }

        [Authorize]
        public ActionResult SuperSecret()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
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