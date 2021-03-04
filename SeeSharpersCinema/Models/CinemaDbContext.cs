using Microsoft.EntityFrameworkCore;

namespace SeeSharpersCinema.Models
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public object Products { get; internal set; }
    }
}
