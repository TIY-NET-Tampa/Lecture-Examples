using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionAndCacheWarmUp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult AddQuestion()
        {

            HttpRuntime.Cache["timeStamp"] = null;


            HttpRuntime.Cache.Remove("timeStamp");

            HttpRuntime.Cache
                   .Add("timeStamp",
                   DateTime.Now,
                   null,
                   DateTime.MaxValue,
                   new TimeSpan(8, 0, 0),
                   System.Web.Caching.CacheItemPriority.Low,
                   null
                   );



            return View();
        }


        public ActionResult Index()
        {
            // Cache per server
            var timeToDisplay = HttpRuntime.Cache["timeStamp"];
            if (timeToDisplay == null)
            {
                // was not in cache
                // place code here to populate the cache

                // TODO: place db call here

                HttpRuntime.Cache
                    .Add("timeStamp",
                    DateTime.Now,
                    null,
                    DateTime.MaxValue,
                    new TimeSpan(8, 0, 0),
                    System.Web.Caching.CacheItemPriority.High,
                    null
                    );
                timeToDisplay = HttpRuntime.Cache["timeStamp"];
            }
            else {
                // was in cache
            }
            ViewBag.FromCache = timeToDisplay;


            // Session per user
            var timeUserFirstCameToSite = Session["userTime"];
            if (timeUserFirstCameToSite == null)
            {
                Session.Add("userTime", DateTime.Now);
            }
            ViewBag.FromSession = Session["userTime"];
            
            return View();
        }
    }
}