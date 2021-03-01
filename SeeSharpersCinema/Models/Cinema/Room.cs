namespace SeeSharpersCinema.Models.Cinema
{
    public class Room
    {
        // TODO Method SeatsLeft capacity--

        public int Id { get; }
        public int Capacity { get; }
        public Cinema Cinema { get; }
        // public List<Seat> SeatList { get; set; }

        public Room(int id, int capacity, Cinema cinema)
        {
            Id = id;
            Capacity = capacity;
            Cinema = cinema;
        }
    }
}
