using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using isa3.Data.Others;
using isa3.Data.People;

namespace isa3.soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<isa3.Data.Others.TrainingData> TrainingData { get; set; }

        public DbSet<isa3.Data.Others.EquipmentData> EquipmentData { get; set; }

        public DbSet<isa3.Data.Others.ServicesData> ServicesData { get; set; }

        public DbSet<isa3.Data.People.CoachData> CoachData { get; set; }
    }
}
