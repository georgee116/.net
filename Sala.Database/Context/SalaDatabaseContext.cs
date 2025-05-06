using Microsoft.EntityFrameworkCore;
using Sala.Database.Entities;
using Sala.Infrastructure.Config;

namespace Sala.Database.Context
{
    public class SalaDatabaseContext : DbContext
    {
        public SalaDatabaseContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppConfig.ConnectionStrings?.SalaDatabase);

            if (AppConfig.ConsoleLogQueries)
            {
                optionsBuilder.LogTo(Console.WriteLine);
            }
        }

        public DbSet<SportsHall> SportsHalls { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
