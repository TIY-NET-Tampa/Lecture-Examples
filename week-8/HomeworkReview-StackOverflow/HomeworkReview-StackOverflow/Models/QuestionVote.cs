using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkReview_StackOverflow.Models
{
    public class QuestionVote
    {
        public int Id { get; set; }
        public int Value { get; set; }

        public DateTime TimeCasted { get; set; } = DateTime.Now;

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}