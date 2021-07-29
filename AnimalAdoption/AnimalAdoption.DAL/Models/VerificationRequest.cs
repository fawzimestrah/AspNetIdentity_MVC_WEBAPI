using LearningIdentity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class VerificationRequest
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Admin))]
        public string AdminId { get; set; }
        [ForeignKey(nameof(Requester))]
        public string RequesterId { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public bool IsVerified { get; set; }
        public bool IsCanceled { get; set; }

        public string  AdminDescription { get; set; }
        
        public ApplicationUser Admin { get; set; }

        public ApplicationUser Requester { get; set; }

        public string PassportUrl { get; set; }

        public DateTime RequestDate { get; set; }

        public DateTime VerificationDate { get; set; }
    }
}
