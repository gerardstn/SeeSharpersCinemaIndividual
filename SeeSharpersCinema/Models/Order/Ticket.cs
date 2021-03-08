using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Price;
using System.Text;

namespace SeeSharpersCinema.Models.Order
{
    public class Ticket
    {
        public enum TicketType
        {
            Normal = 0,
            Child = 1,
            Student = 2,
            Senior = 3
        }
        public Movie Movie { get; set; }

        public double BasePrice = 8.5;

        public double LongMovieAddition = 0.5;
        public double ThreeDimensionalAddition = 2.5;

        public double ChildDiscount = -1.5;
        public double StudentDiscount = -1.5;
        public double SeniorDiscount = -1.5;

        public double TotalPrice(double price = BasePrice);
        if (Movie.IsLongMovie)
        {
            price += LongMovieAddition;
        }
        
        if (Movie.IsThreeDimensional)
        {
            price += ThreeDimensionalAddition;
        }
        if (Movie.//htmlpost input form TicketType.Child && IsChildMovie)
        {
            price += ChildDiscount;
        }
        if (Movie.//htmlpost input form TicketType.Student)
        {
            price += StudentDiscount;
        }
        if (Movie.//htmlpost input form type TicketType.Senior)
        {
            price += SeniorDiscount;
        }
        return price;


/*public double BasePrice()
{
    double priceOnDuration = 8.5;
    if (Movie.Duration > 120)
    {
        priceOnDuration = 9;
    }
    return priceOnDuration;
}*/


    }
}
