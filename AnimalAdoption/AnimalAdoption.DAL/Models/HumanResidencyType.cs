using LearningIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.MVC.Models
{
    public class HumanResidencyType
    {
        public int Id { get; set; }

        public string ResidencyName { get; set; }

        public string ResidencyDescription { get; set; }


        public ICollection<ApplicationUser> Users { get; set; }
    }
}
