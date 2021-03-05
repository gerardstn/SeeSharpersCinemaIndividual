
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeeSharpersCinema.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public ViewIndication ViewIndications { get; set; } // Kijkwijzer (Dutch PEGI)
        public int Year { get; set; }
        public string Technique { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public Genre Genres { get; set; }



    }
}
