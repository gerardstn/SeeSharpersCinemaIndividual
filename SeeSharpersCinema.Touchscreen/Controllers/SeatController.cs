using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System.Linq;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class SeatController : Controller
    {
        private IMovieRepository repository;

        /// <summary>
        /// SeatController constructor
        /// </summary>
        /// <param name="repository">Constructor needs an IMovieRepository object</param>
        public SeatController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get the view Selector
        /// </summary>
        /// <param name="movieId">Method needs a parameter of type long</param>
        /// <returns>Seat view of a specific movie by its id</returns>
        [Route("Seat/Selector/{movieId}")]
        public IActionResult Selector([FromRoute] long movieId)
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
    }
}