using SeeSharpersCinema.Models.Theater;
using System;

namespace SeeSharpersCinema.Models
{
    /// <summary>
    /// Class TimeSlot with properties 
    /// Entity Framework creates a table with Id as primary key and RoomId as foreign key
    /// </summary>
    public class TimeSlot
    {
        //iets maken wat dit genereert aan de hand van de vorige etc
        public long Id { get; set; }
        public DateTime SlotStart { get; set; }
        public DateTime SlotEnd { get; set; }
        public long RoomId { get; set; }
        public Room Room { get; set; }
    }
}
