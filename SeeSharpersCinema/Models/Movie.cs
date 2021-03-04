namespace SeeSharpersCinema.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string ViewIndication { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
    }
}
