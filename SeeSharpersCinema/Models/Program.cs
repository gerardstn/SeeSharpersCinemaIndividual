using SeeSharpersCinema.Models.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Henk the Movie", 130, Genre.Comedy);
            ASpecialPrice child = new Child(8, movie);
            ASpecialPrice threeD1 = new ThreeD(true);
            SpecialPriceList list = new SpecialPriceList();
            list.AddSpecialPriceList(child);
            list.AddSpecialPriceList(threeD1);
            Ticket ticket = new Ticket(movie, list);
            Console.WriteLine($"{ticket.GetTicket()}");
        }
    }
}
