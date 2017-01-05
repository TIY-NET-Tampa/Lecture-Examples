﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RedditClone.Models;

namespace RedditClone.Controllers
{
    public class RedditPostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RedditPosts
        public ActionResult Index()
        {
            var redditPosts = db.RedditPosts.Include(r => r.Poster);
            return View(redditPosts.ToList());
        }

        // GET: RedditPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedditPost redditPost = db.RedditPosts.Find(id);
            if (redditPost == null)
            {
                return HttpNotFound();
            }
            return View(redditPost);
        }

        // GET: RedditPosts/Create
        public ActionResult Create()
        {
            ViewBag.PosterId = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: RedditPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Body,Upvotes,Downvotes,PosterId")] RedditPost redditPost)
        {
            if (ModelState.IsValid)
            {
                db.RedditPosts.Add(redditPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PosterId = new SelectList(db.ApplicationUsers, "Id", "Email", redditPost.PosterId);
            return View(redditPost);
        }

        // GET: RedditPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedditPost redditPost = db.RedditPosts.Find(id);
            if (redditPost == null)
            {
                return HttpNotFound();
            }
            ViewBag.PosterId = new SelectList(db.ApplicationUsers, "Id", "Email", redditPost.PosterId);
            return View(redditPost);
        }

        // POST: RedditPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Body,Upvotes,Downvotes,PosterId")] RedditPost redditPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(redditPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PosterId = new SelectList(db.ApplicationUsers, "Id", "Email", redditPost.PosterId);
            return View(redditPost);
        }

        // GET: RedditPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RedditPost redditPost = db.RedditPosts.Find(id);
            if (redditPost == null)
            {
                return HttpNotFound();
            }
            return View(redditPost);
        }

        // POST: RedditPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RedditPost redditPost = db.RedditPosts.Find(id);
            db.RedditPosts.Remove(redditPost);
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
