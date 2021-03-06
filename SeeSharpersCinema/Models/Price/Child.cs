using SeeSharpersCinema.Models.Film;

namespace SeeSharpersCinema.Models.Price
{
    public class Child : ASpecialPrice
    {
        public override string Name { get => "Child Discount"; }
        public int Age { get; }
        public Movie Movie { get; }

        public Child(int age, Movie movie)
        {
            Age = age;
            Movie = movie;
        }

        private bool validation()
        {
            bool result = false;
            string genre = Movie.Genre.ToString();
            if (Age <= 11 && (genre == "Children" || genre == "Animation"))
            {
                result = true;
            }
            return result;
        }

        public override double PriceDifference()
        {
            double result = 0;
            if (validation())
            {
                result = -1.5;
            }
            return result;
        }
    }
}
