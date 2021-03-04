using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public class Ticket
    {
        public string Title { get; set; }
        public DateTime TimeSlot { get; set; }
        public int RoomID { get; set; }
        public int SeatNum { get; set; }
        public bool Discounted { get; set; }
    }
}
