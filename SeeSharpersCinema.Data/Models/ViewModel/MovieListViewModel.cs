using SeeSharpersCinema.Models.Film;
using System.Collections.Generic;

namespace SeeSharpersCinema.Models.ViewModel
{
    /// <summary>
    /// MovieListViewModel used by the Movie View
    /// </summary>
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
