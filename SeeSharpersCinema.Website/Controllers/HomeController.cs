using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Threading.Tasks;


namespace SeeSharpersCinema.Website.Controllers
{
    public class HomeController : Controller
    {
        private IPlayListRepository repository;

        public HomeController(IPlayListRepository repo)
        {
            repository = repo;
        }

        public async Task<IActionResult> Index()
        {
            var movieWeek = await repository.FindBetweenDatesAsync(DateTime.Now.Date, GetNextThursday());

            if (!String.IsNullOrEmpty(uiTitle))
            {
                movieWeek = await repository.FindByTitle(DateTime.Now.Date, GetNextThursday(), uiTitle);
            }

            if (!String.IsNullOrEmpty(uiDate))
            {

                string[] parts = uiDate.Split('-');
                int year = Int32.Parse(parts[0]);
                int month = Int32.Parse(parts[1]);
                int day = Int32.Parse(parts[2]);

                DateTime newDate = new DateTime(year, month, day, 00, 00, 00);
                movieWeek = await repository.FindByDate(newDate);
            }

            if (movieWeek == null)
            {
                return NotFound();
            }

            return View(movieWeek);
        }

        /// <summary>
        /// Gets the amount of days untill it is Thursday,  and adds this to the current date.
        /// </summary>
        /// <returns>The date of the first upcomming Thursday</returns>
        private DateTime GetNextThursday()
        {
            DateTime today = DateTime.Now.Date;
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysUntilThursday = ((int)DayOfWeek.Thursday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextThursday = today.AddDays(daysUntilThursday);
            return nextThursday;
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
