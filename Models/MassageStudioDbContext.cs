using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassageStudioWebApi.Models
{
    public class MassageStudioDbContext : DbContext
    {
        public MassageStudioDbContext(DbContextOptions<MassageStudioDbContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Мasseur> Мasseurs { get; set; }        
    }
}
