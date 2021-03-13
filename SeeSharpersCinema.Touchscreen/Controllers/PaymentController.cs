using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.Payment;

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