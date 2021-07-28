using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public static class SeedData
    {

        private static async Task AddFriendlies(ApplicationDbContext context)
        {
            bool dataExists = context.FriendlyLevels.Any();
            if (!dataExists)
            {
                await context.FriendlyLevels.AddRangeAsync(new FriendlyLevel { Level = "With People" }, new FriendlyLevel { Level = "With Dogs" }, new FriendlyLevel { Level = "With Cats" }, new FriendlyLevel { Level = "With Kids" });
                await context.SaveChangesAsync();
            }
        }

        private static async Task AddVaccinationLevels(ApplicationDbContext context)
        {
            bool dataExists = context.VaccinationLevels.Any();
            if (!dataExists)
            {
                await context.VaccinationLevels.AddRangeAsync(new VaccinationLevel { Level = "Partially Vaccinated" }, new VaccinationLevel { Level = "Not Vaccinated" }, new VaccinationLevel { Level = "Fully Vaccinated" }, new VaccinationLevel { Level = "Spayed" }, new VaccinationLevel { Level = "Neutred" }, new VaccinationLevel { Level = "Medical issue" });
                await context.SaveChangesAsync();
            }
        }

        private static async Task AddWeights(ApplicationDbContext context)
        {

            bool dataExists = context.Weights.Any();
            if (!dataExists)
            {
                await context.Weights.AddRangeAsync(new Weight { WeightDescription = "Between 2 and 10 Kilos" }, new Weight { WeightDescription = "Between 11 and 30 Kilos" }, new Weight { WeightDescription = "More than 30 kilos" });
                await context.SaveChangesAsync();
            }
        }

        private static async Task AddBreed(ApplicationDbContext context)
        {
            bool dataExists = context.Breeds.Any();
            if (!dataExists)
            {
                await context.Breeds.AddRangeAsync(new Breed { BreedType = "Dog", ParentId = null }, new Breed { BreedType = "Cat", ParentId = null }, new Breed { BreedType = "Rottweiler", ParentId = 1 });
                await context.SaveChangesAsync();
            }
        }


        private static async Task AddEnergies(ApplicationDbContext context)
        {
            bool dataExists = context.EnergyLevels.Any();
            if (!dataExists)
            {
                await context.EnergyLevels.AddRangeAsync(new EnergyLevel { LevelDescription = "Hiper" }, new EnergyLevel { LevelDescription = "Moderate" }, new EnergyLevel { LevelDescription = "Calm" });
                await context.SaveChangesAsync();
            }
        }

        private static async Task AddTrainings(ApplicationDbContext context)
        {
            bool dataExists = context.TrainingLevels.Any();
            if (!dataExists)
            {
                await context.TrainingLevels.AddRangeAsync(new TrainingLevel { Level = "Advanced" }, new TrainingLevel { Level = "Potty Trained" }, new TrainingLevel { Level = "Basic Commands" }, new TrainingLevel { Level = "Not Trained" });
                await context.SaveChangesAsync();
            }
        }


        private static async Task AddCountries (ApplicationDbContext context)
        {
            bool dataExists = context.Countries.Any();
            if (!dataExists)
            {
                var result = File.ReadAllText("countries.json");
                List<Country> countries = JsonSerializer.Deserialize<List<Country>>(result);
                await context.Countries.AddRangeAsync(countries);
                await context.SaveChangesAsync();
            }
        }

        private static async Task AddLivingState(ApplicationDbContext context)
        {
            bool dataExists = context.LivingStates.Any();
            if (!dataExists)
            {
                await context.LivingStates.AddRangeAsync(new LivingState { LivingStateDescription = "Indoor" }, new LivingState { LivingStateDescription = "Outdoor" }, new LivingState { LivingStateDescription = "Indoor-Outdoor" });
                await context.SaveChangesAsync();
            }
        }

        public static async Task SeedAll(ApplicationDbContext context)
        {
            await AddBreed(context);
            await AddEnergies(context);
            await AddFriendlies(context);
            await AddTrainings(context);
            await AddVaccinationLevels(context);
            await AddWeights(context);
            await AddCountries(context);
            await AddLivingState(context);
        }




    }
}
