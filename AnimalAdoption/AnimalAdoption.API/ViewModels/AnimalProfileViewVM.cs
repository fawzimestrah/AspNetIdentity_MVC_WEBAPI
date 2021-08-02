using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AnimalProfileViewVM
    {
        public int AnimalId { get; set; }
        public string  AnimalName { get; set; }
        
        public string  OwnerLocation{ get; set; }

        public string AninalDescription { get; set; }

        public string Weight { get; set; }

        public string VaccinationLevel { get; set; }

        public string EnergyLevel { get; set; }

        public string TrainingLevel { get; set; }

        public string FriendlyLevel { get; set; }

        public string Longtitude { get; set; }

        public string Latitude { get; set; }

        public  List<string> ImageUrls { get; set;t }




    }
}
