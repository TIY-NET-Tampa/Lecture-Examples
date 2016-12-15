using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorExploration.ViewModels;

namespace RazorExploration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //option 1
            //    var vm = new Service.TeamService().GetDashboardData() ;
            //    return View(vm);

            // option 2
            var vm = new DashboardViewModel();
            var service = new Service.TeamService();
            vm.CountOfTotalTeams = service.GetCountOfTeams();
            vm.Games = service.GetRecentGames();
            vm.Teams = service.GetTeams();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}