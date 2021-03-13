namespace SeeSharpersCinema.Models.Theater
{
    public class Cinema
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int TotalRooms { get; set; }
        public int TotalCapacity { get; set; }

    }
}
