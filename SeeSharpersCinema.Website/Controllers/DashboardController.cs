using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Models.Repository;

namespace SeeSharpersCinema.Website.Controllers
{
    public class DashboardController : Controller
    {
        private IPlayListRepository repository;

        public DashboardController(IPlayListRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IActionResult> WeekAsync()
        {
            var playlist = await repository.FindBetweenDatesAsync(DateTime.Now.Date, GetNextThursday());
            return View(playlist);
        }

        private DateTime GetNextThursday()
        {
            DateTime today = DateTime.Now.Date;
            int daysUntilThursday = ((int)DayOfWeek.Thursday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextThursday = today.AddDays(daysUntilThursday);
            return nextThursday;
        }
        private DateTime StringToDateTime(string uiDate)
        {
            string[] parts = uiDate.Split('-');
            int year = Int32.Parse(parts[0]);
            int month = Int32.Parse(parts[1]);
            int day = Int32.Parse(parts[2]);

            return new DateTime(year, month, day, 00, 00, 00);
        }
    }
}
