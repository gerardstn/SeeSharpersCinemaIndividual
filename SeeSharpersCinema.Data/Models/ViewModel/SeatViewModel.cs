using SeeSharpersCinema.Models.Theater;
using SeeSharpersCinema.Models.Film;
using System.Collections.Generic;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class SeatViewModel
    {
        public TimeSlot TimeSlot { get; set; }
        public Movie Movie { get; set; }
        public string SeatingArrangement { get; set; }
        public List<Seat> reserevedSeat { get; set; }
        public long PlayListId { get; set; }
    }
}
