using AnimalAdoption.DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AnimalProfile3VM
    {
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public int  Age { get; set; }
        public string  YearMonth { get; set; }
        public string Gender { get; set; }
        public IFormFileCollection AnimalPhotos { get; set; }
        public int BreedId { get; set; }
        public int DogSizeId { get; set; }
        public int MedicalHistoryId { get; set; }
        public string VaccinationDescription { get; set; }
        public List<Breed> Breeds { get; set; }
        public List<VaccinationLevel> VaccinationLevels { get; set; }


    }
}
