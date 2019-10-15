using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.ToList();
            List<Animal> sortedAnimals = model.OrderBy(x => x.Name).ToList();
            return View(sortedAnimals);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        public ActionResult Edit(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}