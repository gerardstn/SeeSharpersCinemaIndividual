using SeeSharpersCinema.Models.Price;
using SeeSharpersCinema.Models.Theater;
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
            //Movie movie = new Movie("Henk the Movie", 130, Genre.Comedy);
            //ASpecialPrice child = new Child(8, movie);
            //ASpecialPrice threeD1 = new ThreeD(true);
            //SpecialPriceList list = new SpecialPriceList();
            //list.AddSpecialPriceList(child);
            //list.AddSpecialPriceList(threeD1);
            //Ticket ticket = new Ticket(movie, list);
            //Console.WriteLine($"{ticket.GetTicket()}");

            Movie movie1 = new Movie("Henk the Movie", 130, Genre.Comedy);
            Movie movie2 = new Movie("Truus the Movie", 90, Genre.Crime);
            Movie movie3 = new Movie("Ingrid the Movie", 120, Genre.SciFi);
            Cinema cinema = new Cinema("The Roulette", "23 New Drive Avenue", "Boston", "050034343", 10, 400);
            Room room1 = new Room(1, 40, cinema);
            Room room2 = new Room(2, 30, cinema);
            TimeSlot timeSlot1 = new TimeSlot(new DateTime(2021, 3, 3, 17, 00, 00), new DateTime(2021, 3, 3, 19, 00, 00), room1);
            TimeSlot timeSlot2 = new TimeSlot(new DateTime(2021, 3, 3, 17, 00, 00), new DateTime(2021, 3, 3, 19, 00, 00), room2);
            TimeSlot timeSlot3 = new TimeSlot(new DateTime(2021, 3, 3, 19, 30, 00), new DateTime(2021, 3, 3, 21, 00, 00), room1);

            PlayList playList = new PlayList(9);
            playList.AddToPlayList(timeSlot1, movie1);
            playList.AddToPlayList(timeSlot2, movie2);
            playList.AddToPlayList(timeSlot3, movie3);
            // playList.DeleteFromPlayList(timeSlot2);

            Console.WriteLine($"{playList.CountPlayList()} movies in de playlist");

            Dictionary<TimeSlot, Movie> list = new Dictionary<TimeSlot, Movie>();
            list = playList.GetPlayList();

            foreach (KeyValuePair<TimeSlot, Movie> item in list)
            {
                Console.WriteLine($"Start: {item.Key.SlotStart.ToString()}, end: {item.Key.SlotEnd.ToString()}, Movie: {item.Value.Title}, Room: {item.Key.Room.Id}");
            }
        }
    }
}
