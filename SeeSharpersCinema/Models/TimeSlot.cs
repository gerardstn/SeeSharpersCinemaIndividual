using SeeSharpersCinema.Models.Theater;
using System;

namespace SeeSharpersCinema.Models
{
    public class TimeSlot
    {
        public DateTime SlotStart { get; }
        public DateTime SlotEnd { get; }
        public Room RoomId { get; }

        public TimeSlot(DateTime slotStart, DateTime slotEnd, Room roomId)
        {
            SlotStart = slotStart;
            SlotEnd = slotEnd;
            RoomId = roomId;
        }

    }
}
