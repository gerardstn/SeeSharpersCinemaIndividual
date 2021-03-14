﻿using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Threading.Tasks;


namespace SeeSharpersCinema.Website.Controllers
{
    public class HomeController : Controller
    {
        private IPlayListRepository repository;

        /// <summary>
        /// Constructor HomeController
        /// </summary>
        /// <param name="repo">Constructor needs IPlayListRepository object</param>
        public HomeController(IPlayListRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Get the View Index for showing current movieweek
        /// </summary>
        /// <param name="uiTitle">Selection string: user input for title</param>
        /// <param name="uiDate">Selection string: user input string for date</param>
        /// <param name="uiGenre">Selection string: user input string for genre</param>
        /// <param name="uiViewIndication">Selection string: user input string for view indication</param>
        /// <returns>View of current movieweek with or without user selection</returns>
        public async Task<IActionResult> Index(string uiTitle, string uiDate, string uiGenre, string uiViewIndication)
        {
            // Get movies of current filmweek
            var movieWeek = await repository.FindBetweenDatesAsync(DateTime.Now.Date, GetNextThursday());

            // Get movies of current filmweek with this title
            if (!String.IsNullOrEmpty(uiTitle))
            {
                movieWeek = await repository.FindByTitle(DateTime.Now.Date, GetNextThursday(), uiTitle);
            }

            // Get movies of this date
            if (!String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByDate(newDate);
            }

            // Get movies of current filmweek with this genre
            if (!String.IsNullOrEmpty(uiGenre))
            {
                movieWeek = await repository.FindByGenre(DateTime.Now.Date, GetNextThursday(), uiGenre);
            }

            // Get movies of current filmweek with this view indication
            if (!String.IsNullOrEmpty(uiViewIndication))
            {
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, GetNextThursday(), uiViewIndication);
            }

            // Get movies of this date with this title
            if (!String.IsNullOrEmpty(uiTitle) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByTitleAndDate(uiTitle, newDate);
            }

            // Get movies of this date with this genre
            if (!String.IsNullOrEmpty(uiDate) && !String.IsNullOrEmpty(uiGenre))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByDateAndGenre(newDate, uiGenre);
            }

            // Get movies with this view indication of this date
            if (!String.IsNullOrEmpty(uiViewIndication) && !String.IsNullOrEmpty(uiDate))
            {
                DateTime newDate = StringToDateTime(uiDate);
                movieWeek = await repository.FindByViewIndication(DateTime.Now.Date, GetNextThursday(), uiViewIndication);
            }

            // Get movies with this view indication of this genre
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

        /// <summary>
        /// Get the View about the Privacy Policy
        /// </summary>
        /// <returns>View about Privacy Policy</returns>
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
