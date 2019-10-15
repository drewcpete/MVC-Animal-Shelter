namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int AdmittanceDate { get; set; }
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