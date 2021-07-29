using AnimalAdoption.DAL.Models;
using AnimalAdoption.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class PreviewAdoptionProfile
    {
        public string UserId { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string Description { get; set; }

        public AnimalResidencyType AnimalResidencyType {get;set;}

        public bool ExperiencedPetOwner { get; set; }

        public HumanResidencyType HumanResidencyType { get; set; }

        public SocialState SocialState { get; set; }

        public int TimeOutsideHome { get; set; }

    }
}
