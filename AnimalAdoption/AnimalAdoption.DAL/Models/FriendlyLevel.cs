using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    //friendly with people or dogs 
    public class FriendlyLevel
    {
        public int Id { get; set; }

        public string Level { get; set; }

        public string LevelDescription { get; set; }
    }


}
