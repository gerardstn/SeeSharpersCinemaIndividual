using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.ViewModel;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SeeSharpersCinema.Website.Controllers
{
    [Authorize(Roles = "Admin,Cashier")]
    public class PaymentController : Controller
    {
        private IPlayListRepository playlistRepository;
        private IPaymentRepository paymentRepository;


        public PaymentController(IPlayListRepository playlistRepo, IPaymentRepository paymentRepo)
        {
            playlistRepository = playlistRepo;
            paymentRepository = paymentRepo;
        }

        
        public async Task<IActionResult> Index(long? id)
        {
            ClaimsPrincipal currentUser = this.User;

            if (id == null)
            {
                return NotFound();
            }


            var PlayListList = await playlistRepository.FindAllAsync();

            var PlayList = PlayListList.FirstOrDefault(p => p.Id == id);

            if (PlayList == null)
            {
                return NotFound();
            }

            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.PlayList = PlayList;
            return View(paymentViewModel);
        }

   
        public async Task<IActionResult> Pay(long? id)
        {
            ClaimsPrincipal currentUser = this.User;

            if (id == null)
            {
                return NotFound();
            }


            var PlayListList = await playlistRepository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == id);

            if (PlayList == null)
            {
                return NotFound();
            }

            Ticket ticket = new Ticket();
            ticket.MovieId = PlayList.MovieId;
            ticket.TimeSlotId = PlayList.TimeSlotId;
            ticket.Cashier = currentUser.Identity.Name;
            ticket.Movie = PlayList.Movie;
            ticket.Price = ticket.Movie.TotalPrice();

            paymentRepository.AddTicket(ticket);

            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.Ticket = ticket;
            return View("Result", paymentViewModel);
        }
    }
}

