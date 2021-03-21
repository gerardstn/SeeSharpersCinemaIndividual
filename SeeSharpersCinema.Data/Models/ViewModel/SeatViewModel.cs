using SeeSharpersCinema.Data.Models.Repository;
using SeeSharpersCinema.Data.Models.Static;
using SeeSharpersCinema.Models;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Data.Models.ViewModel
{
    public class SeatViewModel
    {
        public Dictionary<int, SeatState> SeatStates { get; set; }
        public TimeSlot TimeSlot { get; set; }    
        public Movie Movie { get; set; }
        public string SeatingArrangement { get; set; }   
    }
}
