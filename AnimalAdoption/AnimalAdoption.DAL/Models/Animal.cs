using LearningIdentity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        [ForeignKey(nameof(User))]
        public string  UserId{ get; set; }

        [ForeignKey(nameof(Breed))]
        public int BreedId { get; set; }

        public ApplicationUser User { get; set; }

        public Breed Breed { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public bool IsVaccinated { get; set; }

      

        public int VaccinationLevelId { get; set; }
        public VaccinationLevel VaccinationLevel { get; set; }

        public int EnergyLevelId { get; set; }

        public FriendlyLevel FriendlyLevel { get; set; }
        public int FriendlyLevelId { get; set; }

        public EnergyLevel EnergyLevel { get; set; }

        public string VaccinationDescription { get; set; }

        public string AnimalDescription { get; set; }

        //outdoor , indoor, 
        public AnimalResidencyType LivingState { get; set; }

        public virtual ICollection<AnimalPhoto> AnimalPhotos { get; set; } 




    }
}
