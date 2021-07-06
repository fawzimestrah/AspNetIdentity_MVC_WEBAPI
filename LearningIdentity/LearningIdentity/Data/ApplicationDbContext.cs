using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningIdentity.ViewModels;
using LearningIdentity.Models;

namespace LearningIdentity.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
