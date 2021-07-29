using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalAdoption.API.ViewModels
{
    public class VerificationRequestVM
    {
        public string UserId { get; set; }

        public string PhoneNumber { get; set; }

        public string PassportUrl { get; set; }

        public IFormFile FormFile { get; set; }
    }
}
