using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models
{
    public interface ICinemaRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
