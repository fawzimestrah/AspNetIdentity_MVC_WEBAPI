using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class AnimalProfileVM
    {
        public int AnimalId { get; set; }

        public List<string> ImagesUrl { get; set; }

        public IFormFileCollection Images { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }
    }
}
