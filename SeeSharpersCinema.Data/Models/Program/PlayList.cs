using SeeSharpersCinema.Models.Film;

namespace SeeSharpersCinema.Models.Program
{
    /// <summary>
    /// Class PlayList with properties 
    /// Entity Framework creates a table with Id as primary key and 
    /// TimeSlotId and MovieId as foreign keys
    /// </summary>
    public class PlayList
    {
        public long Id { get; set; }
        public long TimeSlotId { get; set; }
        public long MovieId { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public Movie Movie { get; set; }
    }
}
