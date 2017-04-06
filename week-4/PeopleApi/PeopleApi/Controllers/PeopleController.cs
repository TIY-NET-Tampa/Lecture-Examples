using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeopleApi.Models;

namespace PeopleApi.Controllers
{
    public class PeopleController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPerson()
        {
            var pete = new Person
            {
                Name = "Peter"
            };
            return Ok(pete);
        }


        [HttpPost]
        public IHttpActionResult CreatePerson(string name)
        {
            var newPerson = new Person
            {
                Name = name
            };
            return Ok(newPerson);
        }
    }
}
