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

        public async Task<IActionResult> Index(string uiTitle, string uiDate, string uiGenre, string uiViewIndication)
        {
            var movieWeek = await repository.FindBetweenDatesAsync(DateTime.Now.Date, GetNextThursday());

            if (!String.IsNullOrEmpty(uiTitle))
            {
                movieWeek = await repository.FindByTitle(DateTime.Now.Date, GetNextThursday(), uiTitle);
            }

            if (!String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByDate(newDate);
            }

            if (!String.IsNullOrEmpty(uiGenre))
            {
                movieWeek = await repository.FindByGenre(DateTime.Now.Date, GetNextThursday(), uiGenre);
            }

            if (!String.IsNullOrEmpty(uiViewIndication))
            {
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, GetNextThursday(), uiViewIndication);
            }

            if (!String.IsNullOrEmpty(uiTitle) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByTitleAndDate(uiTitle, newDate);
            }

            if (!String.IsNullOrEmpty(uiDate) && !String.IsNullOrEmpty(uiGenre))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByDateAndGenre(newDate, uiGenre);
            }

            if (!String.IsNullOrEmpty(uiViewIndication) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, GetNextThursday(), uiViewIndication);
            }

            if (!String.IsNullOrEmpty(uiViewIndication) && !String.IsNullOrEmpty(uiGenre))
            {
                movieWeek = await repository.FindByViewIndicationAndGenre(DateTime.Now.Date, GetNextThursday(), uiViewIndication, uiGenre);
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

        /// <summary>
        /// Converts an userinput string to DateTime
        /// </summary>
        /// <param name="uiDate">string</param>
        /// <returns>A date string converted to DateTime</returns>
        private DateTime StringToDateTime(string uiDate)
        {
            string[] parts = uiDate.Split('-');
            int year = Int32.Parse(parts[0]);
            int month = Int32.Parse(parts[1]);
            int day = Int32.Parse(parts[2]);

            return new DateTime(year, month, day, 00, 00, 00);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
