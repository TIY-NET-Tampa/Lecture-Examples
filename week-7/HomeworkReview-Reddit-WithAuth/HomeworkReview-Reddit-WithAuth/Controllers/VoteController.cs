using HomeworkReview_Reddit_WithAuth.Models;
using HomeworkReview_Reddit_WithAuth.ViewModel;
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
        [HttpPost]
        public ActionResult Up(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == id);
            post.UpVote += 1;
            db.SaveChanges();
            var vm = new VoteButtonContainerViewModel { Post = post, VoteValue = 1 , IsAllowedToVote = HttpContext.User.Identity.IsAuthenticated };
            return PartialView("_voteDisplay", vm);
        }
        // GET: Vote
        [HttpPost]
        public ActionResult Down(int id)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == id);
            post.DownVote += 1;
            db.SaveChanges();
            var vm = new VoteButtonContainerViewModel { Post = post, VoteValue = -1, IsAllowedToVote = HttpContext.User.Identity.IsAuthenticated };
            return PartialView("_voteDisplay", vm);
        }
    }
}