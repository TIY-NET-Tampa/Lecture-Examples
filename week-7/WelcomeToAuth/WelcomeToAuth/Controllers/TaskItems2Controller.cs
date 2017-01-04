using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WelcomeToAuth.Models;

namespace WelcomeToAuth.Controllers
{
    public class TaskItems2Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TaskItems2
        public async Task<ActionResult> Index()
        {
            var taskItems = db.TaskItems.Include(t => t.User);
            return View(await taskItems.ToListAsync());
        }

        // GET: TaskItems2/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = await db.TaskItems.FindAsync(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            return View(taskItem);
        }

        // GET: TaskItems2/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: TaskItems2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Description,IsCompleted,DateCreated,DateCompleted,UserId")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                db.TaskItems.Add(taskItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", taskItem.UserId);
            return View(taskItem);
        }

        // GET: TaskItems2/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = await db.TaskItems.FindAsync(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", taskItem.UserId);
            return View(taskItem);
        }

        // POST: TaskItems2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Description,IsCompleted,DateCreated,DateCompleted,UserId")] TaskItem taskItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.ApplicationUsers, "Id", "Email", taskItem.UserId);
            return View(taskItem);
        }

        // GET: TaskItems2/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskItem taskItem = await db.TaskItems.FindAsync(id);
            if (taskItem == null)
            {
                return HttpNotFound();
            }
            return View(taskItem);
        }

        // POST: TaskItems2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TaskItem taskItem = await db.TaskItems.FindAsync(id);
            db.TaskItems.Remove(taskItem);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
