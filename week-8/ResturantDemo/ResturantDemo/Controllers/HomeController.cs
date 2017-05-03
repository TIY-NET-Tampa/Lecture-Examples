using ResturantDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResturantDemo.ViewModels;
using System.Data.Entity;
namespace ResturantDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var menuFromCache = HttpRuntime.Cache["menu"] as IEnumerable<Category>;
            if (menuFromCache == null)
            {
                var menu = new ApplicationDbContext().Categories.OrderBy(o => o.Name).ToList();
                // add the menu to cache
                HttpRuntime.Cache.Add(
                    "menu",
                    menu,
                    null,
                    DateTime.Now.AddDays(7),
                    new TimeSpan(),
                    System.Web.Caching.CacheItemPriority.High,
                    null);
                menuFromCache = HttpRuntime.Cache["menu"] as IEnumerable<Category>;
            }

            var vm = new HomePageViewModel
            {
                Menu = menuFromCache,
                ShoppingCart = Session["cart"] as Order ?? new Order()
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult ShoppingCart(int id)
        {
            var cart = Session["cart"] as Order;
            if (cart == null)
            {
                // create a new cart
                cart = new Order()
                {
                    Fulfilled = false,
                    TimeCreated = DateTime.Now
                };
            }
            // too get the item
            var itemToAdd = new ApplicationDbContext().MenuItems.Include(i => i.Category).FirstOrDefault(f => f.Id == id);
            // add item select to shopping cart
            cart.Items.Add(itemToAdd);
            Session["cart"] = cart;
            return PartialView("_shoppingCart", cart);
        }

        [HttpDelete]
        public ActionResult RemoveFromCart(string id)
        {

            var cart = Session["cart"] as Order;
            cart.Items = cart.Items.Where(w => w.TrackerId != Guid.Parse(id)).ToList();
            return PartialView("_checkoutDisplayCart", cart);
        }


        public ActionResult Checkout()
        {
            // Shopping Cart (order) as the model
            var vm = Session["cart"] as Order;
            return View(vm);
        }


    }
}