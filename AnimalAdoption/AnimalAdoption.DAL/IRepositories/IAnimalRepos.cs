﻿using AnimalAdoption.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.IRepositories
{
    public interface IAnimalRepos :IGenericRepos<Animal>
    {
        Task<Animal> PreviewAnimal(int animalId);
    }
}
