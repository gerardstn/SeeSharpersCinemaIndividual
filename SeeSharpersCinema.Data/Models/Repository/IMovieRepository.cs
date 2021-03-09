using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
