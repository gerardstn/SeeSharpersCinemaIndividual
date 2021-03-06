namespace SeeSharpersCinema.Models.Price
{
    public abstract class PriceSubtractions
    {
        public abstract string Name { get; }
        public abstract double PriceDifference();
    }
}
