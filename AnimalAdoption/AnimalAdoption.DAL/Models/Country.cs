﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAdoption.DAL.Models
{
    public class Country
    {
        
        [Key]
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
