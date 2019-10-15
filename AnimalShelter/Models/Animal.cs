using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string AdmittanceDate { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public AnimalType PetType { get; set; }
        public string Breed { get; set; }
    }

    public enum AnimalType
    {
        Dog,
        Cat,
        Hairless_Guinea_Pig,
        Ferret,
        Turtle,
        Other
    }
}