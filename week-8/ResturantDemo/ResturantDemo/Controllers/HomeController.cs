using ResturantDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResturantDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var menuFromCache = HttpRuntime.Cache["menu"];
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
                menuFromCache = HttpRuntime.Cache["menu"];

            }
            return View(menuFromCache);
        }

    }
}