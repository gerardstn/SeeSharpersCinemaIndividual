using SeeSharpersCinema.Models.Theater;

namespace SeeSharpersCinema.Models
{
    public class Seat
    {
        public long id { get; set; }
        public int Number { get; set; }
        public int Row { get; set; }
        public Room Room { get; set; }

    }
}
