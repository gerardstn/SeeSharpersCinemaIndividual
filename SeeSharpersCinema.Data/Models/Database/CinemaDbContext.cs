using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Theater;

namespace SeeSharpersCinema.Models.Database
{
    public class CinemaDbContext : DbContext
    {
        /// <summary>
        /// CinemaDbContext constructor with inheritance from superclass DbContext
        /// </summary>
        /// <param name="options">Constructor needs an object of type DbContextOptions<CinemaDbContext></param>
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// Configuration tablecreation from models and adding fakedata
        /// </summary>
        /// <param name="modelBuilder">Method needs an ModelBuilder object</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>().ToTable("Cinema");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<TimeSlot>().ToTable("TimeSlot");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<PlayList>().ToTable("PlayList");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");

            modelBuilder.Entity<Cinema>().HasData(FakeData.FakeCinemas);
            modelBuilder.Entity<Room>().HasData(FakeData.FakeRooms);
            modelBuilder.Entity<TimeSlot>().HasData(FakeData.FakeTimeSlots);
            modelBuilder.Entity<Movie>().HasData(FakeData.FakeMovies);
            modelBuilder.Entity<PlayList>().HasData(FakeData.FakePlayLists);           
        }
    }
}
