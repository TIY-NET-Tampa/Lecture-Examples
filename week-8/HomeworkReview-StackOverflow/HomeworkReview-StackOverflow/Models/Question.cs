using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HomeworkReview_StackOverflow.Models
{
	public class Question
	{
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Asked { get; set; } = DateTime.Now;
        public string Title { get; set; }

		[DisplayName("Has answer")]
        public bool IsAnswered { get; set; } = false;

        // Asker
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        // list of votes
        public ICollection<QuestionVote> Votes { get; set; } = new HashSet<QuestionVote>();


        // TODO: list of comments

    }
}