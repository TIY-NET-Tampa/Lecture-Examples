using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorExploration.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public string HomeTeamName { get; set; }

        public int AwayTeamId { get; set; }
        public string AwayTeamName { get; set; }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }


    }
}