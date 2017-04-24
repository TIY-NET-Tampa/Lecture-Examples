using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeworkReview_Reddit_WithAuth.Models;
using Microsoft.AspNet.Identity;

namespace HomeworkReview_Reddit_WithAuth.Controllers
{
    [Authorize]
    public class PostModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PostModels
        public ActionResult Index()
        {
            return View(db.RedditPosts.ToList());
        }

        // GET: PostModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postModel = db.RedditPosts.Find(id);
            if (postModel == null)
            {
                return HttpNotFound();
            }
            return View(postModel);
        }

        // GET: PostModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,ImageUrl,Body")] PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                postModel.UserId = HttpContext.User.Identity.GetUserId();
                db.RedditPosts.Add(postModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postModel);
        }

        // GET: PostModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postModel = db.RedditPosts.Find(id);
            if (postModel == null)
            {
                return HttpNotFound();
            }
            return View(postModel);
        }

        // POST: PostModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,TimePosted,UpVote,DownVote,ImageUrl,Body,UserId")] PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postModel);
        }

        // GET: PostModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostModel postModel = db.RedditPosts.Find(id);
            if (postModel == null)
            {
                return HttpNotFound();
            }
            return View(postModel);
        }

        // POST: PostModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostModel postModel = db.RedditPosts.Find(id);
            db.RedditPosts.Remove(postModel);
            db.SaveChanges();
            return RedirectToAction("Index");
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
