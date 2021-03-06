using SeeSharpersCinema.Models.Theater;
using System;

namespace SeeSharpersCinema.Models
{
    public class TimeSlot
    {
        public long Id { get; set; }
        public DateTime SlotStart { get; set; }
        public DateTime SlotEnd { get; set; }
    }
}
