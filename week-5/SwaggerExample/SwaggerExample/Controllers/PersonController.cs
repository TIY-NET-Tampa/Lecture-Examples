using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SwaggerExample.Models;
using SwaggerExample.Services;

namespace SwaggerExample.Controllers
{
    public class PersonController : ApiController
    {
        //GET all the people
        [HttpGet]
        public IHttpActionResult GetPeople()
        {
            var people = PersonService.GetAllPeople();
            return Ok(people);
        }

        // GET one person, URL : api/person/[id] or api/person?id=[id]
        [HttpGet]
        public IHttpActionResult GetPerson(Guid id)
        {
            var person = PersonService.GetPerson(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        // PUT a person, create a person
        [HttpPut]
        public IHttpActionResult PutPeople(string name, string haircolor)
        {
            var newPerson = PersonService.CreatePerson(name, haircolor);
            return Ok(newPerson);
        }

        // POST a person, update a person
        [HttpPost]
        public IHttpActionResult UpdatePerson(Person updatedPerson)
        {
            var found = PersonService.UpdatePerson(updatedPerson);
            if (found == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(found);
            }
        }

        // DELETE a person
        [HttpDelete]
        public IHttpActionResult RemovePerson(Guid idToRemove)
        {
            PersonService.DeletePerson(idToRemove);
            return Ok();
        }
    }
}
