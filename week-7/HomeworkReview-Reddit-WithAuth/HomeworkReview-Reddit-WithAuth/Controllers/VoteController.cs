using HomeworkReview_Reddit_WithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_Reddit_WithAuth.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == id);
            post.UpVote += 1;
            db.SaveChanges();
            return PartialView("_voteDisplay", post);
        }
    }
}