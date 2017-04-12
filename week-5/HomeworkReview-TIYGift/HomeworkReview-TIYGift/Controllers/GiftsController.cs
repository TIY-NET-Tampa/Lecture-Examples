using HomeworkReview_TIYGift.Models;
using HomeworkReview_TIYGift.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeworkReview_TIYGift.Controllers
{
    public class GiftsController : Controller
    {

        // Display All Gifts
        // GET: Gifts
        public ActionResult Index()
        {
            // get all gifts from ??? (service class)
            var gifts = GiftService.GetAllGifts();
            return View(gifts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var gift = GiftService.GetGift(id);
            return View(gift);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            // accept  & parse the input (formcollection)
            var updatedGift = new Gift
            {
                Contents = collection["Contents"],
                Hints = collection["Hints"],
                Depth = double.Parse(collection["Depth"]),
                Height = double.Parse(collection["Height"]),
                Weight = double.Parse(collection["Weight"]),
                IsOpened = bool.Parse(collection["IsOpened"]),
                Width = double.Parse(collection["Width"]),
                Id = id
            };
            // save it to our database
            GiftService.UpdateGift(updatedGift);
            // redirect to the correct page 
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Open(int id)
        {
            var gift = GiftService.GetGift(id);
            return View(gift);
        }

        [HttpPost]
        public ActionResult Open(int id, FormCollection collection)
        {
            GiftService.OpenGift(id);
            return RedirectToAction("Index");
        }

       
    }
}