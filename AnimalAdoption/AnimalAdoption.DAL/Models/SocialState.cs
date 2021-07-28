using LearningIdentity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.MVC.Models
{
    public class SocialState
    {
        public int Id { get; set; }
        public string SocialStateName { get; set; }
        public string SocialDescription { get; set; }

        public virtual ICollection<ApplicationUser> User { get; set; }

    }
}
