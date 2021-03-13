using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Website.Controllers
{
    public class PlayListController : Controller
    {
        private IPlayListRepository repository;

        public PlayListController(IPlayListRepository repo)
        {
            repository = repo;
        }

        public async Task<IActionResult> Overview()
        {
            return View(await repository.FindAllAsync());
        }

        //public async Task<IActionResult> MoviesBySelection(string uiDateTime, string uiTitle)
        //{
        //    var movies = repository.FindAllAsync();

        //    if (!String.IsNullOrEmpty(uiDateTime) || !String.IsNullOrEmpty(uiTitle))
        //    {
        //        movies = repository.FindBySelection(uiDateTime, uiTitle);
        //    }

        //    return View(await repository.FindAllAsync());
        //}

        public async Task<IActionResult> MoviesBySelection(string uiDateTime)
        {
            var movies = repository.FindAllAsync();

            if (!String.IsNullOrEmpty(uiDateTime))
            {
                movies = repository.FindBySelection(uiDateTime);
            }

            return View(await movies);
        }

    }
}
