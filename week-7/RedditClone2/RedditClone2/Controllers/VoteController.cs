using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RedditClone2.ViewModels;
using RedditClone2.Models;
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
            Vote userVote;
            if (post != null)
            {
                var userId = User.Identity.GetUserId();
                // get the vote
                userVote = post.Votes.FirstOrDefault(f => f.UserId == userId);
                if (userVote != null)
                {
                    // if different, change the value
                    if (userVote.Weight == VoteWeight.DownVote)
                    {
                        userVote.Weight = VoteWeight.UpVote;
                    }
                    else if (userVote.Weight == VoteWeight.UpVote)
                    {
                        post.Votes.Remove(userVote);
                        userVote = null;
                    }
                }
                else
                {
                    //add vote to vote list
                    var newVote = new Vote
                    {
                        PostId = post.Id,
                        Weight = VoteWeight.UpVote,
                        UserId = userId
                    };
                    post.Votes.Add(newVote);
                    userVote = newVote;
                }
                db.SaveChanges();
                var weightRv = 0;
                if (userVote != null)
                {
                    weightRv = (int)userVote.Weight;
                }
                return Ok(new VoteResponseViewModel { NewCount = post.VoteSum, Vote = weightRv });
            }
            return NotFound();
        }


        [Route("{postId}/down")]
        public IHttpActionResult DownVote([FromUri] int postId)
        {
            var db = new ApplicationDbContext();
            var post = db.RedditPosts.FirstOrDefault(f => f.Id == postId);
            Vote userVote;
            if (post != null)
            {
                var userId = User.Identity.GetUserId();
                // get the vote
                userVote = post.Votes.SingleOrDefault(f => f.UserId == userId);
                if (userVote != null)
                {
                    // if different, change the value
                    if (userVote.Weight == VoteWeight.UpVote)
                    {
                        userVote.Weight = VoteWeight.DownVote;
                    }
                    else if (userVote.Weight == VoteWeight.DownVote)
                    {
                        post.Votes.Remove(userVote);
                        userVote = null;
                    }
                }
                else
                {
                    //add vote to vote list
                    var newVote = new Vote
                    {
                        PostId = post.Id,
                        Weight = VoteWeight.DownVote,
                        UserId = userId
                    };
                    userVote = newVote;
                    post.Votes.Add(newVote);

                }
                db.SaveChanges();
                var weightRv = 0;
                if (userVote != null)
                {
                    weightRv = (int)userVote.Weight;
                }
                return Ok(new VoteResponseViewModel { NewCount = post.VoteSum, Vote = weightRv });
            }
            return NotFound();
        }
    }
}
