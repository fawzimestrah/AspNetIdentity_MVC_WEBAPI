using AnimalAdoption.API.ViewModels;
using AnimalAdoption.DAL.IRepositories;
using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.Actions
{
    public class AnimalActions
    {
        private readonly IGenericRepos<Animal> _animal;
        private readonly IGenericRepos<AnimalPhoto> _animalphoto;
        public AnimalActions(IGenericRepos<Animal> animal, IGenericRepos<AnimalPhoto> animalphoto)
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
                    AnimalPhoto photo = await _animalphoto.Create(new AnimalPhoto { AnimalId = Pet.Id,
                        InsertedDate = DateTime.Now, 
                        PhotoURL = imageUrl });
                    animalPhotos.Add(photo);
                }
            }
        }


    }
}
