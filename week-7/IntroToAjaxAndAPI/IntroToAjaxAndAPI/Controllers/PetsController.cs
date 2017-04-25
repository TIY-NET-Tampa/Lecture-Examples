using IntroToAjaxAndAPI.DataContext;
using IntroToAjaxAndAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroToAjaxAndAPI.Controllers
{
    public class PetsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new PetContext().Petsn.ToList());
        }

        [HttpPost]
        public IHttpActionResult AddPet(Pet pet)
        {

            var db = new PetContext();
            db.Petsn.Add(pet);
            db.SaveChanges();
            return Ok(pet);
        }

    }
}
