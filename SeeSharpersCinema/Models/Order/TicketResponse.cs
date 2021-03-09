using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Theater;

namespace SeeSharpersCinema.Models.Order
{
    public class TicketResponse
    {
        public long TicketID { get; set; }
        public Movie Movie { get; set; }
        public Ticket Ticket { get; set; }
        public Room Room { get; set; }
        public int SeatID { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public bool IsNoDiscount { get; set; }
        public bool IsChildDiscount { get; set; }
        public bool IsStudentDiscount { get; set; }
        public bool IsSeniorDiscount { get; set; }
    }
}
