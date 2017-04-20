using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIAndEF.DataContext;
using APIAndEF.Models;

namespace APIAndEF.Controllers
{
    public class SandwhichesController : ApiController
    {
        private SampleContext db = new SampleContext();

        // GET: api/Sandwhiches
        public IQueryable<Sandwhich> GetSandwhich()
        {
            return db.Sandwhich;
        }

        // GET: api/Sandwhiches/5
        [ResponseType(typeof(Sandwhich))]
        public IHttpActionResult GetSandwhich(int id)
        {
            Sandwhich sandwhich = db.Sandwhich.Find(id);
            if (sandwhich == null)
            {
                return NotFound();
            }

            return Ok(sandwhich);
        }

        // PUT: api/Sandwhiches/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSandwhich(int id, Sandwhich sandwhich)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sandwhich.Id)
            {
                return BadRequest();
            }

            db.Entry(sandwhich).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SandwhichExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Sandwhiches
        [ResponseType(typeof(Sandwhich))]
        public IHttpActionResult PostSandwhich(Sandwhich sandwhich)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sandwhich.Add(sandwhich);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sandwhich.Id }, sandwhich);
        }

        // DELETE: api/Sandwhiches/5
        [ResponseType(typeof(Sandwhich))]
        public IHttpActionResult DeleteSandwhich(int id)
        {
            Sandwhich sandwhich = db.Sandwhich.Find(id);
            if (sandwhich == null)
            {
                return NotFound();
            }

            db.Sandwhich.Remove(sandwhich);
            db.SaveChanges();

            return Ok(sandwhich);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SandwhichExists(int id)
        {
            return db.Sandwhich.Count(e => e.Id == id) > 0;
        }
    }
}