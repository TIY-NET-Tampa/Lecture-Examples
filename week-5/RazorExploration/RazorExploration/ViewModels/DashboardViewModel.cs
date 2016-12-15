using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RazorExploration.Models;

namespace RazorExploration.ViewModels
{
    public class DashboardViewModel
    {
        public int CountOfTotalTeams { get; set; }
        public List<TeamViewModel> Teams { get; set; } = new List<TeamViewModel>();
        public List<Game> Games { get; set; } = new List<Game>();
    }
}