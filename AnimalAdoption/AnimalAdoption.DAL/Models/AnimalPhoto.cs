using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class AnimalPhoto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string PhotoURL { get; set; }

        public bool Main { get; set; }

        public string PublicName { get; set; }

        public DateTime InsertedDate { get; set; } = DateTime.Now;

        [ForeignKey(nameof(Animal))]
        public int AnimalId { get; set; }


        public Animal Animal { get; set; }
 

    }
}
