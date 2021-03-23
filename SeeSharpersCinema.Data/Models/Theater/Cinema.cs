namespace SeeSharpersCinema.Models.Theater
{
    /// <summary>
    /// Class Cinema with properties 
    /// Entity Framework creates a table with Id as primary key 
    /// </summary>
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
