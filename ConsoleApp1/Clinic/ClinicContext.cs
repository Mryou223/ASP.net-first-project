using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clinic
{
    internal class ClinicContext : DbContext
    {
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<appointment> appointments => Set<appointment>();
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-S41BDCKA\\SQLEXPRESS;Database=ClinicContext;Trusted_Connection=True;TrustServerCertificate=True;");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appointment>()
            .HasOne(a => a.Doctor)
            .WithMany(p => p.appointments)
            .HasForeignKey(a => a.DocId);
        }
    }
    }

