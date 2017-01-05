using Microsoft.AspNet.Identity;
using RedditClone2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedditClone2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Welcome TO TIY-IT";
            var db = new ApplicationDbContext();
            var posts = db.RedditPosts.ToList();
            return View(posts);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(RedditPost newPost)
        {
            // Logic Goes here
            if (ModelState.IsValid)
            {
                newPost.PosterId = HttpContext.User.Identity.GetUserId();
                db.RedditPosts.Add(newPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newPost);
            }

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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}