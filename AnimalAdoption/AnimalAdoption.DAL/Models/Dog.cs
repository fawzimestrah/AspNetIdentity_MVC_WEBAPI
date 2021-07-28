using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class Dog : Animal
    {
      
        public int TrainingLevelId { get; set; }
        public TrainingLevel TrainingLevel { get; set; }
        public string TrainingDescription { get; set; }

        public int WeightId { get; set; }

        public Weight Weight { get; set; }

    }
}
