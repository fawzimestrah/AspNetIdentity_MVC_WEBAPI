using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class AnimalFriendly
    {
        [Key]
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public int FriendlyLevelId { get; set; }

        public FriendlyLevel FriendlyLevel { get; set; }

        public Animal Animal { get; set; }

    }
}
