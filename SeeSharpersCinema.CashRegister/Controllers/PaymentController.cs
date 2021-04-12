using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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


        public async Task<IActionResult> Pay(long? id, string BiosbonCode, string madiwodoCode, string rittenkaartCode)
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

            /*Coupon coupon = await paymentRepository.FindAllAsync();

            Ticket ticketUpdate = new

            if (!String.IsNullOrEmpty(BiosbonCode))
            {
                coupon = await paymentRepository.CompareCoupon("NationaleBios", BiosbonCode);
                ticket.Price = Coupon.Discount;
                paymentRepository.Update(ticket.Id);
            }
            if (!String.IsNullOrEmpty(madiwodoCode))
            {
                coupon = await paymentRepository.CompareCoupon("MaDiWoDo", madiwodoCode);
            }
            if (!String.IsNullOrEmpty(rittenkaartCode))
            {
                coupon = await paymentRepository.CompareCoupon("TienRitten", rittenkaartCode);
            }*/

            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.Ticket = ticket;
            //paymentViewModel.Coupon = coupon;
            return View("Result", paymentViewModel);
        }
    }
}

