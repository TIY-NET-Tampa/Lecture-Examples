using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayerRoster.Services;

namespace PlayerRoster.Controllers
{
    public class RosterController : Controller
    {
        // GET: Roster
        public ActionResult Index()
        {
            // get all players
            var players = new PlayerServices().GetAllPlayers();
            // pass them to the view
            return View(players);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var playerName = collection["Name"];
            var skillLevel = collection["SkillLevel"];
            // TODO: Put into our database
            return RedirectToAction("Index");
        }
    }
}