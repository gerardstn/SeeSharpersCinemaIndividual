using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Controllers
{
    public class TicketController : Controller
    {

        public IActionResult Selector()
        {
            Movie movie = new Movie()
            {
                Title = "testmovie",
                Duration = 125,
                Genre = Genre.Children,
                Technique = "3D"

            };
            Ticket ticket = new Ticket()
            {
                Movie = movie
            };
            return View(ticket);
        }
    }
}
