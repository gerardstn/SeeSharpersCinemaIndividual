using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Film;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models;

namespace SeeSharpersCinema.Controllers
{
    public class TicketController : Controller
    {
        private ICinemaRepository repository;
        public TicketController(ICinemaRepository repository) 
        {
            this.repository = repository;
        }

        [Route("Ticket/Selector/{movieId}")]
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