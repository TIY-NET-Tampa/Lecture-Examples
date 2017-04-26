using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToPartials.ViewModel;


namespace IntroToPartials.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult GetNewsStory()
        {
            var vm = new NewsBlock
            {
                Header = "From Server at " + DateTime.Now,
                Ptags = new List<string>
                {
                    "hello",
                    "world"
                }
            };
            return PartialView("_newBlock", vm);
        }
    }
}