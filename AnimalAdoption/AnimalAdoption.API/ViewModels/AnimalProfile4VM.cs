using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AnimalProfile4VM
    {
        public int AnimalId { get; set; }
        public int FriendlyLevelId { get; set; }
        public int EnergyLevelId { get; set; }

        public int TrainingLevelId { get; set; }

        public string AnimalDescription { get; set; }

        public List<FriendlyLevel> FriendlyLevels { get; set; }
        public List<EnergyLevel> EnergyLevels { get; set; }

        public List<TrainingLevel> TrainingLevels { get; set; }

    }
}
