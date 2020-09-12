using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PatientLibrary;
using System;
using System.Net.Http.Headers;

namespace HospitalRepository
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }

        //event or method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Patient>()
                     .ToTable("tblPatient");
            modelBuilder.Entity<PatientProblem>()
                    .ToTable("tblProblems");
            modelBuilder.Entity<Treatment>()
                    .ToTable("tblTreatMents");
        }
        public DbSet<Patient> patients { get; set; }
        public DbSet<PatientProblem> problems { get; set; }
        public DbSet<Treatment> treatments { get; set; }
    }
   }
