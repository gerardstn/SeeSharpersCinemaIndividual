﻿namespace SeeSharpersCinema.Models.Film
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Technique { get; set; }
        public string Description { get; set; }
        public ViewIndication ViewIndication { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string Cast { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public bool IsLongMovie => Duration >= 120;
        public bool IsGenreChild => Genre == Genre.Children;
        public bool IsThreeDimensional => Technique == "3D";

        public double BasePrice = 8.5;
        public double LongMovieAddition = 0.5;
        public double ThreeDimensionalAddition = 2.5;

        public double TotalPrice()
        {
            double price = BasePrice;
            if (IsLongMovie)
            {
                price += LongMovieAddition;
            }

            if (IsThreeDimensional)
            {
                price += ThreeDimensionalAddition;
            }
            return price;
        }
    }
}
