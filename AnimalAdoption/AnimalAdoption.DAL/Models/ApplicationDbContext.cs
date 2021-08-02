using LearningIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public virtual DbSet<Animal> Animals { get; set; }

        public virtual DbSet<AnimalPhoto> AnimalPhotos { get; set; }

        public virtual DbSet<Breed> Breeds { get; set; }

        

        public virtual DbSet<FriendlyLevel> FriendlyLevels { get; set; }

        public virtual DbSet<VaccinationLevel> VaccinationLevels { get; set; }

        public virtual DbSet<Weight> Weights { get; set; }

        public virtual DbSet<EnergyLevel> EnergyLevels { get; set; }

        public virtual DbSet<TrainingLevel> TrainingLevels { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<AnimalResidencyType> LivingStates { get; set; }

        public virtual DbSet<VerificationRequest> VerificationRequests { get; set; }
        public virtual DbSet<AnimalType> AnimalTypes { get; set; }

    }
}
