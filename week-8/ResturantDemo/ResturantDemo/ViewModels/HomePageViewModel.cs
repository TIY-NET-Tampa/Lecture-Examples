using ResturantDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantDemo.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Category> Menu { get; set; }
        public Order ShoppingCart { get; set; }
    }
}