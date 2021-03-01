namespace SeeSharpersCinema.Models
{
    public class PlayList
    {
        public int Id { get; set; }
        public string Room { get; set; }
        public string Date { get; set; }
        public Dictionary<Movie, DateTime> MovieList { get; } = new Dictionary<Movie, DateTime>();

        public void AddMovie(Movie movie, DateTime datetime)
        {
            MovieList.Add(movie, datetime);
        }
    }
}
