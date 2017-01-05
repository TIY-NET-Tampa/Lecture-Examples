using RedditClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedditClone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Welcome TO TIY-IT";
            var db = new ApplicationDbContext();
            var posts = db.RedditPosts.ToList();
            return View(posts);
        }
    }
}
