using LearningIdentity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class AdoptionRequest
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int AnimalId { get; set; }

        [ForeignKey(nameof(Adopter))]
        public string AdopterId { get; set; }

        public ApplicationUser Adopter { get; set; }


        public DateTime ResponseDate { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsCanceled { get; set; }

        public DateTime CancellationDate { get; set; }

        public string RequestMessage { get; set; }
        
        public string CancelDescription { get; set; }


    }
}
