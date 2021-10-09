using Microsoft.EntityFrameworkCore;
using System;

namespace isa3.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : this(
            new DbContextOptionsBuilder<ApplicationDbContext>().Options)
        {
        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             InitializeTables(modelBuilder);
        }

        public static void InitializeTables(ModelBuilder modelBuilder)
        {
            //siia tulevad andmebaasitabelid
        }
    }
}
