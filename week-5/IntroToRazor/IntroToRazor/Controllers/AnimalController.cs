using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToRazor.Controllers
{
    [RoutePrefix("zoo")]
    public class AnimalController : Controller
    {
        // GET: Animal
        [Route("all")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("fish")]
        public ActionResult Aquarium()
        {
            return View();
        }

    }
}