using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Film;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFMovieRepository : IMovieRepository
    {
        private CinemaDbContext context;

        public EFMovieRepository(CinemaDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Movie> Movies => context.Movies;

        //public async Task<IEnumerable<Movie>> FindAllAsync()
        //      => await context.Movies
        //        .OrderBy(movie => movie.PosterUrl)
        //        .ToListAsync();
    }
}
