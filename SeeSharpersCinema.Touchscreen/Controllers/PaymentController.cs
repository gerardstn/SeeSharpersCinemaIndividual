using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Repository;
using System.Threading.Tasks;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class PaymentController : Controller
    {
        private IMovieRepository repository;
        public PaymentController(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [Route("Ticket/Selector/Payment")]
        public async Task<IActionResult> IndexAsync(long movieId)
        {
            if (movieId == 0) 
            { 
                return NotFound(); 
            }

            var movie = await repository.Movies.FirstOrDefaultAsync(m => m.Id == movieId);

            if (movie == null) 
            { 
                return NotFound(); 
            }

            return View(movie);
        }

        public IActionResult Pay()
        {
            SeeSharpersCinema.Models.EmailService emailService = new SeeSharpersCinema.Models.EmailService();
            emailService.email_send();
            return RedirectToAction("Overview", "Playlist");
        }
    }
}