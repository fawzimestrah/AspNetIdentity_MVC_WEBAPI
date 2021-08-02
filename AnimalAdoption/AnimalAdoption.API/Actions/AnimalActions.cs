using AnimalAdoption.API.ViewModels;
using AnimalAdoption.DAL.IRepositories;
using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.Actions
{
    /// <summary>
    /// PDF 42
    /// </summary>
    public class AnimalActions
    {
        //private readonly IGenericRepos<Animal> _animal;
        private readonly IGenericRepos<AnimalPhoto> _animalphoto;
        private readonly IAnimalRepos _animal;
        public AnimalActions(IAnimalRepos animal, IGenericRepos<AnimalPhoto> animalphoto)
        {
            _animal = animal;
            _animalphoto = animalphoto;
        }

        public async Task AddFirstPetProfile(AnimalProfileVM animal)
        {
            Animal Pet = new Animal();
            if (animal.AnimalId != default(int))
            {
                Pet = await _animal.GetById(animal.AnimalId);
                if (Pet != null)
                {
                    Pet.UserId = animal.UserId;
                    Pet.DateOfBirth = animal.DateOfBirth;
                    Pet.AnimalDescription = animal.Description;
                }
                await _animal.Update(Pet);
            }
            else
            {
                Pet = new Animal
                {
                    UserId = animal.UserId,
                    DateOfBirth = animal.DateOfBirth,
                    AnimalDescription = animal.Description
                };
                Pet = await _animal.Create(Pet);
            }

            if (animal.Images.Count() > 0)
            {
                List<string> ImagesUrl = await animal.Images.SaveImages("Animals");
                List<AnimalPhoto> animalPhotos = new List<AnimalPhoto>();
                foreach (string imageUrl in ImagesUrl)
                {
                    AnimalPhoto photo = await _animalphoto.Create(new AnimalPhoto
                    {
                        AnimalId = Pet.Id,
                        InsertedDate = DateTime.Now,
                        PhotoURL = imageUrl
                    });
                    animalPhotos.Add(photo);
                }
            }
        }

        public async Task AddSecondAnimalProfile(AnimalProfile2VM animal)
        {
            Animal animalDb = await _animal.GetById(animal.AnimalId);
            animalDb.AnimalTypeId = animal.AnimalTypeId;
            await _animal.Update(animalDb);
        }

        public async Task AddThirdAnimalProfile(AnimalProfile3VM animal)
        {
            Animal animalDb = await _animal.GetById(animal.AnimalId);
            if (animalDb != null)
            {
                animalDb.Name = animal.AnimalName;
                animalDb.Age = animal.Age;
                animalDb.MonthYear = animal.YearMonth;
                animalDb.Gender = animal.Gender;
                animalDb.VaccinationLevelId = animal.MedicalHistoryId;
                animalDb.VaccinationDescription = animal.VaccinationDescription;
                animalDb.BreedId = animal.BreedId;
                await _animal.Update(animalDb);
                List<string> ImagesUrl = await animal.AnimalPhotos.SaveImages("Animals");
                List<AnimalPhoto> animalPhotos = new List<AnimalPhoto>();
                foreach (string imageUrl in ImagesUrl)
                {
                    AnimalPhoto photo = await _animalphoto.Create(new AnimalPhoto
                    {
                        AnimalId = animalDb.Id,
                        InsertedDate = DateTime.Now,
                        PhotoURL = imageUrl
                    });
                    animalPhotos.Add(photo);
                }
            }
        }

        public async Task AddFourthAnimalProfile(AnimalProfile4VM animal)
        {
            Animal animalDb = await _animal.GetById(animal.AnimalId);
            if (animalDb != null)
            {
                animalDb.AnimalDescription = animal.AnimalDescription;
                animalDb.FriendlyLevelId = animal.FriendlyLevelId;
                animalDb.EnergyLevelId = animal.EnergyLevelId;
                animalDb.TrainingLevelId = animal.TrainingLevelId;
                await _animal.Update(animalDb);
            }
        }


        public async Task<AnimalProfileViewVM> PreviewAnimalProfile(int animalId)
        {
            var animal = await _animal.PreviewAnimal(animalId);
            AnimalProfileViewVM profile = new AnimalProfileViewVM
            {
                AnimalId = animal.Id,
                AnimalName = animal.Name,
                AninalDescription = animal.AnimalDescription,
                EnergyLevel = animal.EnergyLevel.LevelDescription,
                FriendlyLevel = animal.FriendlyLevel.LevelDescription,
                ImageUrls = animal.AnimalPhotos.Select(x => x.PhotoURL).ToList(),
                TrainingLevel = animal.TrainingLevel.Level,
                VaccinationLevel = animal.VaccinationLevel.Level,
                Weight = animal.Weight.WeightDescription,
                Latitude = animal.User.Latitude,
                Longtitude =animal.User.Longtitude
            };
            return profile;
        }












    }
}
