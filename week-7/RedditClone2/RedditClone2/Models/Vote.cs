using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RedditClone2.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public RedditPost Post { get; set; }

        public Vote Upvote()
        {
            this.Weight = 1;
            return this;
        }

        public Vote DownVote()
        {
            this.Weight = -1;
            return this;
        }
    }
}