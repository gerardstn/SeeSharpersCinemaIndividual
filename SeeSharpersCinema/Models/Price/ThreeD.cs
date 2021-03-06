namespace SeeSharpersCinema.Models.Price
{
    public class ThreeD : ASpecialPrice
    {
        public override string Name { get; }
        public bool IsThreeD { get; }

        public ThreeD(bool threeD)
        {
            Name = "3D Addition";
            IsThreeD = threeD;
        }

        public override double PriceDifference()
        {
            double result = 0;
            if (IsThreeD)
            {
                result = 2.5;
            }
            return result;
        }
    }
}
