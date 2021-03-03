using SeeSharpersCinema.Models.Cinema;
using System;

namespace SeeSharpersCinema.Models
{
    public class TimeSlot
    {
        public DateTime SlotStart { get; }
        public DateTime SlotEnd { get; }
        public Room Room { get; }

        public TimeSlot(DateTime slotStart, DateTime slotEnd, Room room)
        {
            SlotStart = slotStart;
            SlotEnd = slotEnd;
            Room = room;
        }

    }
}
