using System.Collections.Generic;

namespace AnimalAdoption.DAL.Models
{
    public class AnimalType
    {
        public int Id { get; set; }
        public string AnimalTypeName { get; set; }
        public string AnimalTypeDescription { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}