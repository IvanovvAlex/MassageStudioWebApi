using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class MassageStudioDbContext : DbContext
    {
        public MassageStudioDbContext()
        {
            Database.EnsureCreated();
        }
        public MassageStudioDbContext(DbContextOptions<MassageStudioDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Masseur> Masseurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Reservation>().HasOne(x => x.Client)/*.WithMany(x => x.ClientReservations)*/;
            modelbuilder.Entity<Reservation>().HasOne(x => x.Мasseur)/*.WithMany(x => x.MasseurReservations)*/;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=MassageStudioDb;Integrated Security=True");
            }
        }
    }
}
