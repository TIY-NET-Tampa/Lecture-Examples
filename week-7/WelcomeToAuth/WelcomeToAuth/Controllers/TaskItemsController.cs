using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeToAuth.Models;
using Microsoft.AspNet.Identity;

namespace WelcomeToAuth.Controllers
{
    [Authorize]
    public class TaskItemsController : Controller
    {
        // List of all my tasks
        // GET: TaskItems
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var userId = User.Identity.GetUserId();
            var myTasks = db.TaskItems.Where(w => w.UserId == userId);
            return View(myTasks);
        }

        public ActionResult Add()
        {
            var db = new ApplicationDbContext();
            var newTask = new TaskItem()
            {
                Description = " Do Something",
                UserId = User.Identity.GetUserId()
            };
            db.TaskItems.Add(newTask);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}