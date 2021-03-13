using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public async Task<IActionResult> Index(string uiTitle, string uiDate)
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
        public DateTime GetNextThursday()
        {
            DateTime today = DateTime.Now.Date;
            //Voorbeeld voor vrijdag: 4 - 5 + 7 = 6 dagen tot donderdag. mooie uitleg: https://stackoverflow.com/questions/6346119/datetime-get-next-tuesday
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
