using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System.Linq;

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