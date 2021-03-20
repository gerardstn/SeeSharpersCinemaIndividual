using SeeSharpersCinema.Models.Film;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IMovieRepository
    {
        /// <summary>
        /// IMovieRepository interface makes sure classes implement 
        /// a property of type IQueryable<Movie>
        /// </summary>
        IQueryable<Movie> Movies { get; }
    }
}
