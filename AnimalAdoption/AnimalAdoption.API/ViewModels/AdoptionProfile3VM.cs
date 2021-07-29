using AnimalAdoption.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AdoptionProfile3VM
    {
        public int SocialStateId { get; set; }

        public int HoursAwayFromHome { get; set; }

        public string UserId { get; set; }

        public List<SocialState> SocialStates { get; set; }
    }
}
