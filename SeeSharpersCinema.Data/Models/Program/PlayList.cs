using SeeSharpersCinema.Models.Film;

namespace SeeSharpersCinema.Models.Program
{
    public class PlayList
    {
        public long Id { get; set; }
        public long TimeSlotId { get; set; }
        public long MovieId { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public Movie Movie { get; set; }

        //public int Week { get; set;  }

        //public Dictionary<TimeSlot, Movie> Program { get; set; }

        //public Dictionary<TimeSlot, Movie> GetPlayList()
        //{
        //    return Program;
        //}

        //public void AddToPlayList(TimeSlot timeSlot, Movie movie)
        //{
        //    Program.Add(timeSlot, movie);
        //}

        //public int CountPlayList()
        //{
        //    return Program.Count;
        //}

        //public void DeleteFromPlayList(TimeSlot timeSlot)
        //{
        //    Program.Remove(timeSlot);
        //}
    }
}
