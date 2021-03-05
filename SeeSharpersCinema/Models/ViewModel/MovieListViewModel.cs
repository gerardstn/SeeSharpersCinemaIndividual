using System.Collections.Generic;
using SeeSharpersCinema.Models;
using SeeSharpersCinema.Models.Film;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
