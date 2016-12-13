using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeeperRazorStudies.Models;
using DeeperRazorStudies.ViewModels;

namespace DeeperRazorStudies.Controllers
{
    public class AnimalController : Controller
    {

        public static List<Animal> Animals = new List<Animal> {
               new Animal {Name ="Squirrel", FurColor="Brown", Species="rodent" ,Id=1},
               new Animal {Name ="Lions", FurColor="Gold", Species="Cat",Id=2},
               new Animal {Name = "Cat", FurColor ="Orange", Species="Cat",Id=3 },
               new Animal {Name = "Monkey", FurColor="grey", Species="Primate",Id=4 }
        };

        // GET: Animal
        public ActionResult Index()
        {
            return View(new IndexViewModel { Animals = Animals, Count = Animals.Count() });
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var newAnimal = new Animal
            {
                Id = new Random().Next(4, 100),
                Name = collection["name"],
                FurColor = collection["furColor"],
                Species = collection["species"]
            };
            Animals.Add(newAnimal);
            return RedirectToAction("Index");
        }

        // GET the form
        public ActionResult Edit(int id)
        {
            var animalToEdit = Animals.First(f => f.Id == id);
            return View(animalToEdit);
        }

        // POST: /Animal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var animal = Animals.First(f => f.Id == id);
            animal.Age = int.Parse(collection["age"]);
            animal.FurColor = collection["furColor"];
            animal.Name = collection["name"];
            return RedirectToAction("Index");
        }
    }
}