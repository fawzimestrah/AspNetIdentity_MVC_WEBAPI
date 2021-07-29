using AnimalAdoption.API.ViewModels;
using AnimalAdoption.DAL.IRepositories;
using LearningIdentity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.Actions
{
    public class AccountActions
    {
        private readonly IGenericRepos<ApplicationUser> _user;

        public AccountActions(IGenericRepos<ApplicationUser> user)
        {
            _user = user;
        }

        public async Task UpdateFirstAdoptionProfile(AdoptionProfileVM adoptionProfile)
        {
            ApplicationUser user = await _user.GetById(adoptionProfile.UserId);
            if (user != null)
            {
                if (adoptionProfile.Image != null)
                {
                    adoptionProfile.ImageUrl = await adoptionProfile.Image.SaveImage("Accounts");
                }
                user.DateOfBirth = adoptionProfile.DateOfBirth;
                user.ImageUrl = adoptionProfile.ImageUrl;
                user.PersonalDescription = adoptionProfile.Description;
                await _user.Update(user);
            }
        }

        public async Task UpdateSecondAdoptionProfile(AdoptionProfile2VM adoptionProfile)
        {
            ApplicationUser user = await _user.GetById(adoptionProfile.UserId);
            if (user != null)
            {
                user.firstTimeToAdopt = adoptionProfile.ExperiencedPetOwner;
                user.HumanResidencyTypeId = adoptionProfile.HumanResidencyTypeId;
                user.AnimalResidencyTypeId = adoptionProfile.AnimalResidencyTypeId;
                await _user.Update(user);
            }
        }

        public async Task PreviewProfile(string UserId)
        {
            var selectedUser = await _user.GetAll()
                .Include(x => x.SocialState)
                .Include(x => x.HumanResidencyType)
                .Include(x => x.AnimalResidencyType)
                .Select(x=> new PreviewAdoptionProfile
                {
                    Age = (int)(DateTime.Now -  x.DateOfBirth).TotalDays / 365,
                    AnimalResidencyType = x.AnimalResidencyType,
                    HumanResidencyType = x.HumanResidencyType,
                    FullName =x.firstName +" "+x.lastName,
                    Description = x.PersonalDescription,
                    ExperiencedPetOwner = x.firstTimeToAdopt,
                    SocialState = x.SocialState,
                    TimeOutsideHome=x.HoursAwayFromHome,
                    UserId = x.Id
                }).SingleOrDefaultAsync();

        }



    }
}
