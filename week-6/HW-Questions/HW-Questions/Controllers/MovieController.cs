using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW_Questions.Models;

namespace HW_Questions.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View(Movies);
        }
        public static List<Movie> Movies { get; set; } = new List<Movie>();

        // Create a movie
        // GET 
        public ActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection data)
        {

            var newMovie = new Movie
            {
                Tagline = data["tagline"],
                Title = data["title"],
                YearReleased = int.Parse(data["yearReleased"])
            };
            Movies.Add(newMovie);
            return RedirectToAction("Index");
        }


    }
}