using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkReview_VideoRental.Models;
namespace HomeworkReview_VideoRental.Controllers
{
    /*
     Video REntal Questions:
     - X Date out Range exception w/SQL 
     - X When to use a ViewModel
     - X How would i handle checkin and check out
     - X ViewBag - what??? (dropdowns)
      -  X Rental Log??? What is it? How do use it?
     - Data passing & Objects -- from page to page (preview sessions & Cache)
     - Pagination?!?!?!
         */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            // To a have a dropdown of Genre
            // could 
            var genres = new List<Genre>
            {
                new Genre {Id = 1, Name ="Horror"},
                new Genre {Id = 2, Name = "Rom Com"},
                new Genre {Id  = 3, Name = "Thriller"}
            };

            ViewBag.ListOfGenres = genres.Select(s => new SelectListItem { Value = s.Id.ToString(), Text = s.Name });

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            var genreId = collection["Genres"];

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