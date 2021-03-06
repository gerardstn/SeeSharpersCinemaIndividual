using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public interface ICinemaRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
