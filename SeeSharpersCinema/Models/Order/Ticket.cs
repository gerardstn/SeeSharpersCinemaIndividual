using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Price;
using System.Text;

namespace SeeSharpersCinema.Models.Order
{
    public class Ticket
    {
        public Movie Movie { get; set; }

        public double BasePrice()
        {
            double priceOnDuration = 8.5;
            if (Movie.Duration > 120)
            {
                priceOnDuration = 9;
            }
            return priceOnDuration;
        }
    }
}
