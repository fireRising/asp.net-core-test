using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClassifProject.Models;

namespace ClassifProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Classifiers> Classifiers { get; set; }
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<EnlargedGroups> EnlargedGroups { get; set; }
        public DbSet<Specialties> Specialties { get; set; }
        public DbSet<Transcoding> Transcoding { get; set; }
    }
}
