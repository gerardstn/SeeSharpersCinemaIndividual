using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Theater;
using SeeSharpersCinema.Models.Program;

namespace SeeSharpersCinema.Models.Database
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        // public DbSet<Cinema> Cinemas { get; set; }
        // public DbSet<Room> Rooms { get; set; }
        // public DbSet<TimeSlot> TimeSlots { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
    }
}
