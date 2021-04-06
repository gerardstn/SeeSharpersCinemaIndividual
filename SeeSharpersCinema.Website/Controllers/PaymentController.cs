using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Website.Controllers
{

    public class PaymentController : Controller
    {
        private IPlayListRepository repository;
        public PaymentController(IPlayListRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Open payment overview
        /// </summary>
        /// <param name="movieId">Id used to select correct PlayList object</param>
        /// <returns>Payment View</returns>
        [Route("Payment/Pay/{movieId}")]
        public async Task<IActionResult> IndexAsync([FromRoute] long? movieId)
        {
            if (movieId == null)
            {
                return NotFound();
            }
            var PlayListList = await repository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == movieId);

            if (PlayList == null)
            {
                return NotFound();
            }

            return View(PlayList);
        }

        /// <summary>
        /// Sends email to customer with QR code
        /// </summary>
        /// <returns>Payment View</returns>
        public IActionResult MolliePayment()
        {
            SeeSharpersCinema.Models.EmailService emailService = new SeeSharpersCinema.Models.EmailService();
            // emailService.email_send();
            return View();
        }
    }
}

