namespace SeeSharpersCinema.Models
{
    public class Movie
        // TODO 3 params for testing purposes
    {
        public string Title { get; }
        public int Duration { get; }
        // public string Description { get; }
        // public string ViewIndication { get; }
        public Genre Genre { get; }
        // public int Year { get; }
        // public string Director { get; }
        // public string Country { get; }

        // Constructor param: string description, string viewIndication, int year, string Director, string Country
        public Movie(string title, int duration, Genre genre)
        {
            Title = title;
            Duration = duration;
            //Description = description;
            //ViewIndication = viewIndication;
            Genre = genre;
            //Year = year;
            //Director = director;
            //Country = country;
        }
    }
}
