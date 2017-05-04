using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homereview__Events.Models;
namespace Homereview__Events.ViewModel
{
    public class HomePageViewModel
    {
        public IEnumerable<EventModel>   Events { get; set; }
        public Order ShoppingCart { get; set; } = new Order();
    }
}