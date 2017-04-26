using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeReview_Ajax.Models;

namespace HomeReview_Ajax.Controllers
{
    public class MarblesController : ApiController
    {

        public static List<Marble> listOfMarbles = new List<Models.Marble>
        {
            new Marble{ Id = 1, Color = "Red"},

            new Marble{ Id = 2, Color = "Green"},

            new Marble{ Id = 3, Color = "Blue"},

            new Marble{ Id = 4, Color = "Magenta"},
        };

        public IHttpActionResult Get()
        {
            return Ok(listOfMarbles);
        }

        [HttpPost]
        public IHttpActionResult GetRandom(int count)
        {
            var rand = new Random().Next(0, listOfMarbles.Count);
            return Ok(listOfMarbles[rand]);
        }


    }
}
