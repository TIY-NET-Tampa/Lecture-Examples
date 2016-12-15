using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorExploration.ViewModels
{
    public class TeamViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlayerCount { get; set; }
        public string ImageUrl { get; set; }

    }
}