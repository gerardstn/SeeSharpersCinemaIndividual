using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;

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
        public IActionResult Index([FromRoute] long movieId)
        {
            return View();
        }

        public IActionResult Pay()
        {
            SeeSharpersCinema.Models.EmailService emailService = new SeeSharpersCinema.Models.EmailService();
            emailService.email_send();
            return RedirectToAction("Overview", "Playlist");
        }
    }
}