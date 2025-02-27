﻿using AnimalAdoption.DAL.Models;
using AnimalAdoption.MVC.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningIdentity.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(200,ErrorMessage ="Please do not exceed 200 characters!")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string FullName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string typeOfWork { get; set; }
        public string ImageUrl { get; set; }
        public bool firstTimeToAdopt { get; set; }
        public bool livingAlone { get; set; }

        [ForeignKey(nameof(HumanResidencyType))]
        public int HumanResidencyTypeId { get; set; }

        [ForeignKey(nameof(SocialState))]
        public int SocialStateId { get; set; }

        [ForeignKey(nameof(AnimalResidencyType))]
        public int AnimalResidencyTypeId { get; set; }
        public int HoursAwayFromHome { get; set; }

        public string PersonalDescription { get; set; }

        public string Latitude  { get; set; }

        public string Longtitude { get; set; }

        public AnimalResidencyType AnimalResidencyType { get; set; }
        public HumanResidencyType HumanResidencyType { get; set; }
        public SocialState SocialState { get; set; }
    }
}
