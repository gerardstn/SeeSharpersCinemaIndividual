using System;
using System.Collections.Generic;

namespace SeeSharpersCinema.Models
{
    public class PlayList
    {
        public int Week { get; }
        public Dictionary<TimeSlot, Movie> Program { get; }

        public PlayList(int week)
        {
            Week = week;
            Program = new Dictionary<TimeSlot, Movie>();
        }

        public Dictionary<TimeSlot, Movie> GetPlayList()
        {
            return Program;
        }

        public void AddToPlayList(TimeSlot timeSlot, Movie movie)
        {
            Program.Add(timeSlot, movie);
        }

        public int CountPlayList()
        {
            return Program.Count;
        }

        public void DeleteFromPlayList(TimeSlot timeSlot)
        {
            Program.Remove(timeSlot);
        }
    }
}
