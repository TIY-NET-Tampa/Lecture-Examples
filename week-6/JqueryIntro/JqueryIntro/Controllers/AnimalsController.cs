using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JqueryIntro.Models;

namespace JqueryIntro.Controllers
{
    public class AnimalsController : ApiController
    {
        public static List<Animal> Zoo = new List<Animal>() {
               new Animal {Id =1, Name ="Fluff-ball", Species="cat" },
               new Animal { Id = 2,  Name="Moon Pie", Species="black bear" },
               new Animal {Id =3, Name="Squiggles", Species="snake" }
        };



        public IHttpActionResult Get()
        {
            return Ok(Zoo);
        }

        [HttpPost]
        public IHttpActionResult Add(Animal animal)
        {
            Zoo.Add(animal);
            return Ok(Zoo);
        }

    }
}
