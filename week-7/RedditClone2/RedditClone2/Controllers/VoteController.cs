using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedditClone2.ViewModels;
using RedditClone2.Models;
using System.Web;
using Microsoft.AspNet.Identity;


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
                var newVote = new Vote
                {
                    PostId = postId,
                    UserId = User.Identity.GetUserId(),
                }.Upvote();
                post.Votes.Add(newVote);
                db.SaveChanges();
                return Ok(new VoteResponseViewModel { NewCount = post.VoteSum });
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
                var newVote = new Vote
                {
                    PostId = postId,
                    UserId = User.Identity.GetUserId(),
                }.DownVote();
                post.Votes.Add(newVote);
                db.SaveChanges();
                return Ok(new VoteResponseViewModel { NewCount = post.VoteSum });
            }
            return NotFound();
        }
    }
}
