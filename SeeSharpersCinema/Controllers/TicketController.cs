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
        [Route("Ticket/Selector/{movieId}")]
        public IActionResult Selector([FromRoute] int movieId)
        {
            Movie movie = new Movie()
            {
                Id = movieId,
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
