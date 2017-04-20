using Homework_Review__Bootstrap.Models;
using Homework_Review__Bootstrap.Services;
using Homework_Review__Bootstrap.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_Review__Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        /*
         Questions
           - X tid bits - on how to go from mock up/idea to implementation 
           - X how to take in params from the URL
               - pagination
               - Post
           - Add a view and hooking it up correctly 
           - X when an item is past the 12 
           - X Displaying the data from the view model
           - Connectiong to the Database * this is today lesson 
             */

        public ActionResult Index(int pageNum = 1)
        {
            var vm = new IndexViewModel();
            vm.Games = new GameService().GetAllGames().ToList();
            vm.PageNumber = pageNum;
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(string HomeTeam)
        {
            var vm = new IndexViewModel();
            ViewBag.TeamName = HomeTeam;
            vm.Games = new List<Game>
            {
                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Swashbucklers", AwayTeam="Colonies", Id =1},


                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Dragons", AwayTeam="Lancers", Id =2},


                new Game { AwayScore = 10, HomeScore = 12, HomeTeam = "Waves", AwayTeam="Anchors", Id =5}
            };
            ViewBag.PageNum = 1;
            return View(vm);
        }
    }



}