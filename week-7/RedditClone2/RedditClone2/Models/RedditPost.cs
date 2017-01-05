using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RedditClone2.Models
{
    public class RedditPost
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public string Body { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }

        public string PosterId { get; set; }


        [ForeignKey("PosterId")]
        public virtual ApplicationUser Poster { get; set; }

    }
}