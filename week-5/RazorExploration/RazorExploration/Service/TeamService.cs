using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RazorExploration.ViewModels;
using RazorExploration.Models;

namespace RazorExploration.Service
{
    public class TeamService
    {
        public DashboardViewModel GetDashboardData()
        {
            var vm = new DashboardViewModel();
            vm.CountOfTotalTeams = this.GetCountOfTeams();
            
            
            //vm.CountOfTotalTeams = 813; // this would be normally populated by a service/database call
            vm.Teams.Add(new TeamViewModel { Name = "Eagles", PlayerCount = 4 });
            vm.Teams.Add(new TeamViewModel { Name = "Bears", PlayerCount = 3 });
            vm.Teams.Add(new TeamViewModel { Name = "Hawks", PlayerCount = 15 });
            vm.Teams.Add(new TeamViewModel { Name = "Lightning", PlayerCount = 14 });
            vm.Teams.Add(new TeamViewModel { Name = "Panthers", PlayerCount = 10 });

            vm.Games.Add(new Models.Game { Id = 1, HomeTeamName = "Eagles", AwayTeamName = "Bears", AwayScore = 4, HomeScore = 6 });

            return vm;
        }

        public int GetCountOfTeams()
        {
            return 813;
        }
        public List<TeamViewModel> GetTeams(int Count = 10)
        {
            return new List<TeamViewModel>();
        }
        public List<Game> GetRecentGames(int count = 10)
        {
            return new List<Game>();
        }
    }
}