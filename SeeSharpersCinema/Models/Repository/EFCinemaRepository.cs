using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFCinemaRepository : ICinemaRepository
    {
        private CinemaDbContext context;

        public EFCinemaRepository(CinemaDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Movie> Movies => context.Movies;
    }
}
