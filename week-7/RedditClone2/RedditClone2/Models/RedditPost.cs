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
        public string PosterId { get; set; }
        [ForeignKey("PosterId")]
        public virtual ApplicationUser Poster { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

        public int UpVote
        {
            get
            {
                return Votes.Count(w => w.Weight == VoteWeight.UpVote);
            }
        }

        public int DownVote
        {
            get
            {
                return Votes.Count(w => w.Weight == VoteWeight.DownVote);
            }
        }
        public int VoteSum
        {
            get
            {
                return this.UpVote - this.DownVote;
            }
        }

    }
}