using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Film;

namespace SeeSharpersCinema.Models
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
