using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homereview__Events.Models;
namespace Homereview__Events.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            var vm = Session["cart"] as Order;
            return View(vm);
        }

        public ActionResult Purchase()
        {
            // this is where we would save to the database
            var cart = Session["cart"] as Order;
            if (cart == null)
            {
                RedirectToAction("Index", "Home");
            }

            var db = new ApplicationDbContext();
            cart.TimeCreated = DateTime.Now;
            foreach(var item in cart.Tickets)
            {
                item.DatePurchased = DateTime.Now;
            }
            db.Orders.Add(cart);
            db.SaveChanges();
            return View(cart);
        }
    }
}