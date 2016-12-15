using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap.Controllers
{
    public class ThingController : Controller
    {
        // GET: Thing
        public ActionResult Index()
        {
            return View();
        }

        // GET: Thing/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Thing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thing/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Thing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Thing/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Thing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Thing/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
