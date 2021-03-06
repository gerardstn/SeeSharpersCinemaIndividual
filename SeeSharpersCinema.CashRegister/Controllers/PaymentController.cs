using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeeSharpersCinema.CashRegister.Controllers
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

            string type = "";
            var Coupon = await paymentRepository.CompareCoupon(type, BiosbonCode);

            if (PlayList == null)
            {
                return NotFound();
            }

            Ticket ticket = new Ticket();
            ticket.MovieId = PlayList.MovieId;
            ticket.TimeSlotId = PlayList.TimeSlotId;
            ticket.Cashier = currentUser.Identity.Name;
            ticket.Movie = PlayList.Movie;
            if (madiwodoCode != null || BiosbonCode != null || rittenkaartCode != null)
            {
                if (madiwodoCode == null && BiosbonCode == null && rittenkaartCode != null)
                {
                    type = "TienRitten";
                    await paymentRepository.CompareCoupon(type, rittenkaartCode);
                    var coupon = await paymentRepository.GetCoupon(rittenkaartCode);

                    ticket.Price = ticket.Movie.TotalPrice();
                    ticket.TryAddCoupon(coupon);
                }
                else if (rittenkaartCode == null && BiosbonCode == null && madiwodoCode != null)
                {
                    type = "MaDiWoDo";
                    await paymentRepository.CompareCoupon(type, madiwodoCode);
                    var coupon = await paymentRepository.GetCoupon(madiwodoCode);
                    ticket.Price = ticket.Movie.TotalPrice();
                    ticket.TryAddCoupon(coupon);
                }
                else if (madiwodoCode == null && rittenkaartCode == null && BiosbonCode != null)
                {
                    type = "NationaleBios";
                    await paymentRepository.CompareCoupon(type, BiosbonCode);
                    var coupon = await paymentRepository.GetCoupon(BiosbonCode);
                    ticket.Price = ticket.Movie.TotalPrice();
                    ticket.TryAddCoupon(coupon);
                }
            }
            else
            {
                ticket.Price = ticket.Movie.TotalPrice();
            }

            paymentRepository.AddTicket(ticket);

            PaymentViewModel paymentViewModel = new PaymentViewModel();
            paymentViewModel.Ticket = ticket;
            return View("Result", paymentViewModel);
        }
    }
}

