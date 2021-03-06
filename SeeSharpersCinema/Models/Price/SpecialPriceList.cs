using System.Collections.Generic;
using System.Text;

namespace SeeSharpersCinema.Models.Price
{
    public class SpecialPriceList
    {
        public List<ASpecialPrice> List { get; } = new List<ASpecialPrice>();

        public void AddSpecialPriceList(ASpecialPrice aSpecialPrice)
        {
            List.Add(aSpecialPrice);
        }

        public void RemoveSpecialPriceList(ASpecialPrice aSpecialPrice)
        {
            List.Remove(aSpecialPrice);
        }

        public int CountSpecialPriceList()
        {
            return List.Count;
        }

        public void ClearSpecialPriceList(ASpecialPrice aSpecialPrice)
        {
            List.Clear();
        }

        public double TotalSpecialPrices()
        {
            double total = 0;

            foreach (ASpecialPrice item in List)
            {
                total += item.PriceDifference();
            }
            return total;
        }

        public StringBuilder TariffName()
        {
            StringBuilder tariffs = new StringBuilder();
            foreach (ASpecialPrice item in List)
            {
                tariffs.Append(item.Name + " ");
            }
            return tariffs;
        }
    }
}
