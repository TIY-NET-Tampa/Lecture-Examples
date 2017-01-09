using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RedditClone2.Models
{
    public class Vote
    {
        [Key, Column(Order =0)]
        public string UserId { get; set; }

        [Key, Column(Order = 1)]
        public int PostId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        [ForeignKey("PostId")]
        public RedditPost Post { get; set; }

        public VoteWeight Weight { get; set; }

    }
}