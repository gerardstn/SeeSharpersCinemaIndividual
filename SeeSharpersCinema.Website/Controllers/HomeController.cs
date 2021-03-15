using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Infrastructure;
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
            var movieWeek = await repository.FindBetweenDatesAsync(DateTime.Now.Date, DateHelper.GetNextThursday());

            if (!String.IsNullOrEmpty(uiTitle))
            {
                movieWeek = await repository.FindByTitle(DateTime.Now.Date, DateHelper.GetNextThursday(), uiTitle);
            }

            if (!String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = DateHelper.StringToDateTime(uiDate);
                movieWeek = await repository.FindByDate(newDate);
            }

            if (!String.IsNullOrEmpty(uiGenre))
            {
                movieWeek = await repository.FindByGenre(DateTime.Now.Date, DateHelper.GetNextThursday(), uiGenre);
            }

            if (!String.IsNullOrEmpty(uiViewIndication))
            {
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, DateHelper.GetNextThursday(), uiViewIndication);
            }

            if (!String.IsNullOrEmpty(uiTitle) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = DateHelper.StringToDateTime(uiDate);
                movieWeek = await repository.FindByTitleAndDate(uiTitle, newDate);
            }

            if (!String.IsNullOrEmpty(uiDate) && !String.IsNullOrEmpty(uiGenre))
            {
                DateTime newDate = DateHelper.StringToDateTime(uiDate);
                movieWeek = await repository.FindByDateAndGenre(newDate, uiGenre);
            }

            if (!String.IsNullOrEmpty(uiViewIndication) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = DateHelper.StringToDateTime(uiDate);
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, DateHelper.GetNextThursday(), uiViewIndication);
            }

            if (!String.IsNullOrEmpty(uiViewIndication) && !String.IsNullOrEmpty(uiGenre))
            {
                movieWeek = await repository.FindByViewIndicationAndGenre(DateTime.Now.Date, DateHelper.GetNextThursday(), uiViewIndication, uiGenre);
            }

            if (movieWeek == null)
            {
                return NotFound();
            }

            return View(movieWeek);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
