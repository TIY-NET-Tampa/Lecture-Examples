using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToRazor.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult All()
        {
            return View();
        }
        
        // GET: Movie
        public ActionResult One(int id)
        {
            return View();
        }

        // GET: Movie
        public ActionResult TopFive()
        {
            return View();
        }

    }
}