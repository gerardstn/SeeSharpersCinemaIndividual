namespace SeeSharpersCinema.Models.Theater
{
    public class Cinema
    {
        public string Name { get; }
        public string Address { get; }
        public string City { get; }
        public string Phone { get; }
        public int TotalRooms { get; }
        public int TotalCapacity { get; }

        public Cinema(string name, string address, string city, string phone, int totalRooms, int totalCapacity)
        {
            Name = name;
            Address = address;
            City = city;
            Phone = phone;
            TotalRooms = totalRooms;
            TotalCapacity = totalCapacity;
        }

    }
}
