using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            return View(model);
        }
    }
}