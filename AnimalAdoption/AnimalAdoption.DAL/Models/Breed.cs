using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string BreedType { get; set; }
        public string Description { get; set; }

        public Nullable<int> ParentId { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}

/*
 * id = 1   type=Dog   parentId=null
 * id = 2   type=rottweiler parentId=1 
 * 
 * **/
