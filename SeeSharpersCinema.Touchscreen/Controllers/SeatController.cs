using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System.Linq;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class SeatController : Controller
    {
        private IMovieRepository repository;
        public SeatController(IMovieRepository repository)
        {
            this.repository = repository;
        }

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