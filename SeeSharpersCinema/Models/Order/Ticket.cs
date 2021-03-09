using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Film;
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

        public TicketResponse TicketResponse;

        public double BasePrice = 8.5;

        public double LongMovieAddition = 0.5;
        public double ThreeDimensionalAddition = 2.5;

        public double ChildDiscount = -1.5;
        public double StudentDiscount = -1.5;
        public double SeniorDiscount = -1.5;

        public bool IsNotHoliday = true; //TODO: het ding hier achter
        public bool IsMonToThursday = true; //TODO: het ding hier achter
        public bool IsBeforeSix = true; //TODO: het ding hier achter

        public bool IsChildDiscountValid => IsBeforeSix == Movie.IsGenreChild;
        public bool IsSeniorDiscountValid => IsMonToThursday == IsNotHoliday;
        public bool IsStudentDiscountValid => IsMonToThursday;







        public double TotalPrice()
        {
            double price = BasePrice;
            if (Movie.IsLongMovie)
            {
                price += LongMovieAddition;
            }

            if (Movie.IsThreeDimensional)
            {
                price += ThreeDimensionalAddition;
            }

/*            if (Discount == "Child" & IsChildDiscountValid)
            {
                price += ChildDiscount;
            }*/
            //if (Movie.//htmlpost input form TicketType.Student && IsStudentDiscountValid)
            //{
            //    price += StudentDiscount;
            //}
            //if (Movie.//htmlpost input form type TicketType.Senior && IsSeniorDiscountValid)
            //{
            //    price += SeniorDiscount;
            //}
            return price;
        }
    }
}
