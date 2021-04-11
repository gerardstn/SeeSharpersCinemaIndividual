using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.ViewModel;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Website.Controllers
{

    public class PaymentController : Controller
    {
        private IPlayListRepository playlistRepository;
        private IPaymentRepository paymentRepository;

        public PaymentController(IPlayListRepository playlistRepo, IPaymentRepository paymentRepo )
        {
            playlistRepository = playlistRepo;
            paymentRepository = paymentRepo;
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
            ticket.Cashier = currentUser.Identity.Name;



            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.PlayList = PlayList;
            paymentViewModel.Ticket = ticket;
            return View(paymentViewModel);

        }

/*        public async Task<IActionResult> Success(long? id)
        {
            var ticket = await paymentRepository.GetTicket(id);
            return View(ticket);
        }*/




    }
}

