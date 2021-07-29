using AnimalAdoption.DAL.Models;
using AnimalAdoption.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AdoptionProfile2VM
    {
        public string UserId { get; set; }

        public bool ExperiencedPetOwner { get; set; }

        public int HumanResidencyTypeId { get; set; }
        
        public int AnimalResidencyTypeId { get; set; }
        

        public List<HumanResidencyType> HumanResidencyTypes { get; set; } 

        public List<AnimalResidencyType> AnimalResidencyTypes { get; set; }
    }
}
