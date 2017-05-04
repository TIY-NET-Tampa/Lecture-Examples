using Homereview__Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Homereview__Events.CacheServices;
using Homereview__Events.ViewModel;

namespace Homereview__Events.Controllers
{
    public class HomeController : Controller
    {
        private string eventCacheKey = CacheKeys.Events();

        public ActionResult Index()
        {
            // all events, with venue and genre down the to view 
            var schedule = HttpRuntime.Cache[eventCacheKey] as IEnumerable<EventModel>;
            if (schedule == null)
            {
                var data = new ApplicationDbContext().Events.Include(i => i.Genre).Include(i => i.Venue).ToList();
                HttpRuntime.Cache.Add(
                    eventCacheKey,
                    data,
                    null,
                    DateTime.Now.AddDays(13),
                    new TimeSpan(),
                    System.Web.Caching.CacheItemPriority.High,
                    null
                    );
                schedule = data as IEnumerable<EventModel>;
            }

            var vm = new HomePageViewModel
            {
                Events = schedule,
                ShoppingCart = Session["cart"] as Order ?? new Order()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddToCart(int eventId)
        {
            // add that event to the order in session
            // get the order in the session, create if it doesnt exists
            var cart = Session["cart"] as Order;
            if (cart == null)
            {
                cart = new Order();
            }
            var db = new ApplicationDbContext(); 
            var eventToAdd = db.Events.FirstOrDefault(f => f.Id == eventId);
            //create the ticket
            var ticket = new Ticket
            {
                EventId = eventToAdd.Id,
                PurchasedPrice = eventToAdd.Price, 
                Event = eventToAdd
            };
            cart.Tickets.Add(ticket);

            // save the new cart to seession
            Session["cart"] = cart;
            db.ShoppingCart.Add(cart as ShoppingCart);
            //retrutn the partial with the updated stuff
            return PartialView("_shoppingCart", cart);
        }
    }
}