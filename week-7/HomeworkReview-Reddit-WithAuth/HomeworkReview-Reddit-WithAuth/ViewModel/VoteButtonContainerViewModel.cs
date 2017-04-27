using HomeworkReview_Reddit_WithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HomeworkReview_Reddit_WithAuth.ViewModel
{
    public class VoteButtonContainerViewModel
    {
        public PostModel Post { get; set; }
        public int VoteValue { get; set; } = 0; // 1/0/-1
        public bool IsAllowedToVote { get; set; } = false;
    }
}