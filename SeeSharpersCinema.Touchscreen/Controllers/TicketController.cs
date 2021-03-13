using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Repository;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class TicketController : Controller
    {
        private IMovieRepository repository;
        public TicketController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [Route("Ticket/Options/{movieId}")]
        public IActionResult Options([FromRoute] long movieId)
        {
            var selectedMovie = repository.Movies.FirstOrDefault(m => m.Id == movieId);
            if (selectedMovie == null)
            {
                return NotFound();
            }

            Ticket ticket = new Ticket()
            {
                Movie = selectedMovie
            };
            return View(ticket);
        }

        [Route("Ticket/QR/{TicketId}")]
        public IActionResult QR(Ticket ticket)
        {
            return View(ticket);
        }
    }
}