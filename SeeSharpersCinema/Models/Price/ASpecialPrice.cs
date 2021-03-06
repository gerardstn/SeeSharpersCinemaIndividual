namespace SeeSharpersCinema.Models.Price
{
    public abstract class ASpecialPrice
    {
        public abstract string Name { get; }

        public abstract double PriceDifference();

    }
}
