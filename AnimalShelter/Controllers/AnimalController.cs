using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;
using System;

namespace AnimalShelter.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index(string orderVar)
        {
            System.Console.WriteLine(orderVar);
            List<Animal> model = _db.Animals.ToList();
           
            ViewBag.NameSortParm = String.IsNullOrEmpty(orderVar) ? "name_desc" : "";
            ViewBag.AgeSortParm = orderVar == "Age" ? "age_desc" : "Age";
            ViewBag.TypeSortParm = orderVar == "Type" ? "type_desc" : "Type";
            
            switch (orderVar)
            {
                case "name_desc":
                    model = model.OrderByDescending(s => s.Name).ToList();
                    break;
                case "Age":
                    model = model.OrderBy(s => s.Age).ToList();
                    break;
                case "age_desc":
                    model = model.OrderByDescending(s => s.Age).ToList();
                    break;
                case "Type":
                    model = model.OrderBy(s => s.PetType).ToList();
                    break;
                case "type_desc":
                    model = model.OrderByDescending(s => s.PetType).ToList();
                    break;
                default:
                    model = model.OrderBy(s => s.Name).ToList();
                    break;
            }
            return View(model.ToList());

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
        
        public ActionResult Delete(int id)
        {
            var thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            _db.Animals.Remove(thisAnimal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}