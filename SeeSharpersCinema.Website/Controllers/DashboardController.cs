using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Infrastructure;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Threading.Tasks;

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
            var playlist = await repository.FindBetweenDatesAsync(DateTime.Now.Date, DateHelper.GetNextThursday());
            return View(playlist);
        }
    }
}
