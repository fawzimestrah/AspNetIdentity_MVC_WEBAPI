using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AnimalProfile2VM
    {
        public int AnimalId { get; set; }

        public string AnimalTypeName { get; set; }

        public int AnimalTypeId { get; set; }

        public string AnimalTypeDescription { get; set; }

        public List<AnimalType> AnimalTypes { get; set; } 
    }
}
