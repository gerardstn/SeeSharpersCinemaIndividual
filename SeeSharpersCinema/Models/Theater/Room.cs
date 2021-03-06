namespace SeeSharpersCinema.Models.Theater
{
    public class Room
    {
        public long Id { get; set; }
        public int Capacity { get; set; }
        public Cinema Cinema { get; set; }
        // public List<Seat> SeatList { get; set; }

        // public void CountDownCapacity(int seats) => Capacity -= seats;
    }
}
