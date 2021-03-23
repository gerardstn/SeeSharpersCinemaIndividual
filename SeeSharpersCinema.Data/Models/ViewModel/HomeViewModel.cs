using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Website;
using System.Collections.Generic;

namespace SeeSharpersCinema.Data.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<PlayList> Playlists { get; set; }
        public Notice Notices { get; set; }
    }
}
