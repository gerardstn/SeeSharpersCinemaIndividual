using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Repository;

namespace SeeSharpersCinema.Controllers
{
    public class TicketController : Controller
    {
        private IMovieRepository repository;
        public TicketController(IMovieRepository repository) 
        {
            this.repository = repository;
        }

        [HttpGet, Route("Ticket/Options/{movieId}")]
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

        [HttpPost, Route("Ticket/Options/{movieId}")]
        public IActionResult Options(TicketResponse ticketResponse , [FromRoute] long movieId)
        {
            var selectedMovie = repository.Movies.FirstOrDefault(m => m.Id == movieId);
            if (selectedMovie == null)
            {
                return NotFound();
            }
            OrderRepository.AddResponse(ticketResponse);

            Ticket ticket = new Ticket()
            {
                Movie = selectedMovie
            };
            return View("Pin", ticketResponse);
        }
        public ViewResult ListResponses()
        {
            return View(OrderRepository.Responses.Where(r => r.IsChildDiscount == true));
        }
    }
}