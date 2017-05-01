using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeworkReview_StackOverflow.Models;
namespace HomeworkReview_StackOverflow.ViewModel
{
    public class ProfileViewModel
    {
        public ApplicationUser CurrentUser { get; set; }
        public IEnumerable<Question> Questions { get; set; }      
    }
}