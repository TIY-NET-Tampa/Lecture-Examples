using HomeworkReview_Reddit_WithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_Reddit_WithAuth.Controllers
{
    /*
     Questions: 
     - Up/Down Button
     - X how to get one user to onyl have 1 upvote -- new model???
     - X homepage viewmodel  - iterating over the list of post 
        - yuuuge problem 
        - type error?
     - X?? Metadata error ????
     - X API vs Non-API
     - Level 3?
     - X My workflow for scafolding error with errors that 
     - X change a background color of the site
     - relative datetime (1 hour ago, 2 hr ago) 
          
         */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new ApplicationDbContext().RedditPosts.OrderByDescending(o => o.TimePosted).ToList();
            return View(vm);
        }
    }
}