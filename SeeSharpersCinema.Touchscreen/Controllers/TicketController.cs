using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System.Linq;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class TicketController : Controller
    {

        private IMovieRepository repository;

        /// <summary>
        /// TicketController constructor
        /// </summary>
        /// <param name="repository">Constructor needs an IMovieRepository object</param>
        public TicketController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get the view Options
        /// </summary>
        /// <param name="movieId">Method needs a parameter of type long</param>
        /// <returns>Ticket view of a specific movie by its id</returns>
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

        /// <summary>
        /// Get the view QR
        /// </summary>
        /// <param name="ticket">Method needs a Ticket object</param>
        /// <returns>Ticket view of a specific ticket object</returns>
        [Route("Ticket/QR/{TicketId}")]
        public IActionResult QR(Ticket ticket)
        {
            return View(ticket);
        }
    }
}