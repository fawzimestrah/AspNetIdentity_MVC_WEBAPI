using AnimalAdoption.DAL.IRepositories;
using AnimalAdoption.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Repositories
{
    public class AnimalRepos : GenericRepos<Animal>, IAnimalRepos
    {
        public AnimalRepos(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Animal> PreviewAnimal(int animalId)
        {
            var animal = await _context.Animals.Where(x => x.Id == animalId)
                .Include(x => x.FriendlyLevel)
                .Include(x => x.VaccinationLevel)
                .Include(x => x.Weight)
                .Include(x => x.EnergyLevel)
                .Include(x => x.User)
                .Include(x => x.AnimalPhotos).FirstOrDefaultAsync();
            return animal;
        }
    }
}
