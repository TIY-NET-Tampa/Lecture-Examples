using HomeworkReview_StackOverflow.Models;
using HomeworkReview_StackOverflow.ViewModel;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_StackOverflow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new ApplicationDbContext().Questions.ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult Search(SearchParams param)
        {
            var results = new ApplicationDbContext().Questions
                .Where(w => w.Title.Contains(param.Needle) || w.Text.Contains(param.Needle))
                .ToList();
            return PartialView("_QuestionsTable", results);
        }
        
        public ActionResult MyData()
        {
            var vm = new ProfileViewModel();
            var userId = HttpContext.User.Identity.GetUserId();
            vm.Questions = new ApplicationDbContext().Questions.Where(w => w.UserId == userId);
            vm.CurrentUser = new ApplicationDbContext().Users.FirstOrDefault(w => w.Id == userId);
            return View(vm);
        }
    }
}