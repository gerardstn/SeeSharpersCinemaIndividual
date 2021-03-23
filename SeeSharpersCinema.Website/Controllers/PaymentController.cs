using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace SeeSharpersCinema.Website.Controllers
{

    public class PaymentController : Controller
    {
        private IPlayListRepository repository;
        public PaymentController(IPlayListRepository repo)
        {
            repository = repo;
        }

        [Route("Payment/Pay")]

        public async Task<IActionResult> IndexAsync(long? movieId)
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

        public async Task<IActionResult> Index()
        {
            var movieWeek = await repository.FindBetweenDatesAsync(DateTime.Now.Date, GetNextThursday());
            if (movieWeek == null)
            {
                return NotFound();
            }
            return View(movieWeek);
        }
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await repository.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public DateTime GetNextThursday()
        {
            DateTime today = DateTime.Now.Date;
            int daysUntilThursday = ((int)DayOfWeek.Thursday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextThursday = today.AddDays(daysUntilThursday);
            return nextThursday;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MolliePayment()
        {
            SeeSharpersCinema.Models.EmailService emailService = new SeeSharpersCinema.Models.EmailService();
            emailService.email_send();
            return View();
        }
    }
}

