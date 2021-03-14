using Microsoft.AspNetCore.Mvc.Rendering;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Program;
using System.Collections.Generic;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class MovieSelectorViewModel
    {
        // TODO Eventueel [NotMapped] voor properties die niet meehoeven naar de tabel
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<PlayList> PlayLists { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
