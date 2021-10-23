using Microsoft.EntityFrameworkCore;
using System;
using isa3.Data.Others;
using isa3.Data.People;
using isa3.Domain.Others;

namespace isa3.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : this(
            new DbContextOptionsBuilder<ApplicationDbContext>().Options)
        { }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TrainingData> TrainingData { get; set; }
        public DbSet<EquipmentData> EquipmentData { get; set; }
        public DbSet<CoachData> CoachData { get; set; }
        public DbSet<ServicesData> ServicesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //siia tulevad andmebaasitabelid
            modelBuilder.Entity<TrainingData>().ToTable("Trainings");
            modelBuilder.Entity<EquipmentData>().ToTable("Equipments");
        }
    }
}
