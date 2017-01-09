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

        public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();

        public int UpVotes
        {
            get
            {
                return
                    Votes.Count(c => c.Weight > 0);
            }
        }

        public int DownVotes
        {
            get
            {
                return Votes.Count(c => c.Weight < 0);
            }
        }

        public int VoteSum
        {
            get
            {
                return this.UpVotes - this.DownVotes;
            }
        }



        public Vote GetUserVote (string userId)
        {
            return Votes.FirstOrDefault(f => f.UserId == userId);
        }

    }
}