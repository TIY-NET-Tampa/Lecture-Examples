using Homereview__Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Homereview__Events.CacheServices;
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
            return View(schedule);
        }

      
    }
}