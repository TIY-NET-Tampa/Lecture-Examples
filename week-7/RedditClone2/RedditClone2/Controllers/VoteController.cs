using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedditClone2.ViewModels;
using RedditClone2.Models;

namespace RedditClone2.Controllers
{
    [Authorize]
    [RoutePrefix("api/vote")]
    public class VoteController : ApiController
    {
        [Route("{postId}/up")]
        public IHttpActionResult UpVote([FromUri] int postId)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == postId);
            if (post != null)
            {
                post.Upvotes++;
                db.SaveChanges();
                return Ok(new VoteResponseViewModel { NewCount = post.Upvotes - post.Downvotes});
            }
            return NotFound();
        }


        [Route("{postId}/down")]
        public IHttpActionResult DownVote([FromUri] int postId)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == postId);
            if (post != null)
            {
                post.Downvotes++;
                db.SaveChanges();
                return Ok(new VoteResponseViewModel { NewCount = post.Upvotes - post.Downvotes });
            }
            return NotFound();
        }
    }
}
