using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AdoptionProfileVM
    {
        public string UserId { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }


    }
}
