using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeeperRazorStudies.Models;

namespace DeeperRazorStudies.ViewModels
{
    public class IndexViewModel
    {
        public int Count { get; set; }
        public List<Animal> Animals { get; set; }
    }
}