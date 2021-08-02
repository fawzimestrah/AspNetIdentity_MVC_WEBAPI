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
        public string UserId { get; set; }

        [ForeignKey(nameof(Breed))]
        public int BreedId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        private string monthYear;
        public string MonthYear
        {
            get { return this.monthYear; }
            set
            {
                if (value.ToLower() == "month" || value.ToLower() == "year")
                { this.monthYear = value; }
                else { this.monthYear = "year"; }
            }
        }

        public string Gender { get; set; }

        public bool IsVaccinated { get; set; }

        [ForeignKey(nameof(AnimalType))]
        public int AnimalTypeId { get; set; }
        public int VaccinationLevelId { get; set; }
        public int EnergyLevelId { get; set; }
        public int FriendlyLevelId { get; set; }
        public string VaccinationDescription { get; set; }
        
        [ForeignKey(nameof(Weight))]
        public int WeightId { get; set; }

        

        [ForeignKey(nameof(TrainingLevel))]
        public int TrainingLevelId { get; set; }
        public string AnimalDescription { get; set; }

        public Weight Weight { get; set; }
        public FriendlyLevel FriendlyLevel { get; set; }
        public VaccinationLevel VaccinationLevel { get; set; }
        public EnergyLevel EnergyLevel { get; set; }
        public AnimalResidencyType LivingState { get; set; }
        public ApplicationUser User { get; set; }

        public TrainingLevel TrainingLevel { get; set; }
        public Breed Breed { get; set; }
        public AnimalType AnimalType { get; set; }

        public virtual ICollection<AnimalPhoto> AnimalPhotos { get; set; }




    }
}
