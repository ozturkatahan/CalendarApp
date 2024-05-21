using CalendarApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalendarApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<ReservationType> ReservationTypes { get; set; }

    }

   
}
