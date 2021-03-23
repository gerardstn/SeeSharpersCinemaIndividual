using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFMovieRepository : IMovieRepository
    {
        private CinemaDbContext context;
        public IQueryable<Movie> Movies => context.Movies;

        /// <summary>
        /// EFMovieRepository constructor
        /// </summary>
        /// <param name="ctx">Constructor needs a CinemaDbContext object</param>
        public EFMovieRepository(CinemaDbContext ctx)
        {
            context = ctx;
        }
    }
}
