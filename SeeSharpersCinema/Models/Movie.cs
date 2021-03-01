namespace SeeSharpersCinema.Models
{
    public class Movie
    {
        public string Title { get; }
        public int Duration { get; }
        public int Release { get; }
        public Genre Genre { get; }
        public string Description { get; }

        public Movie(string title, int duration, Genre genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }
    }
}
