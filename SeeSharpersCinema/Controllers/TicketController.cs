using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index => View();

        public IActionResult Home => View();

        [HttpGet("{ticket}")]
        public ActionResult<Ticket> Qr(Ticket ticket) => View(ticket);

        public ActionResult Print(Ticket ticket) => View(ticket);
    }
}
