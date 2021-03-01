namespace SeeSharpersCinema.Models
{
    public class Ticket
    {
        public Movie Movie { get; set; }
        private double _price => GetPrice();
        public double Price { get => _price; }
        public SpecialPriceList List { get; set; }
        public StringBuilder TariffNames { get; }

        public Ticket(Movie movie, SpecialPriceList list)
        {
            Movie = movie;
            List = list;
            TariffNames = list.TariffName();
        }

        private double GetPrice()
        {
            double result = 0;
            if (Movie.Duration > 120)
            {
                result = 9 + List.TotalSpecialPrices();
            }
            else
            {
                result = 8.5 + List.TotalSpecialPrices();
            }
            return result;
        }

        public string GetTicket()
        {
            return $"Movie: {Movie.Title}\nDuration: {Movie.Duration}\nPrice: {Price}\nDiscounts/Additions: {TariffNames}";
        }
    }
}
