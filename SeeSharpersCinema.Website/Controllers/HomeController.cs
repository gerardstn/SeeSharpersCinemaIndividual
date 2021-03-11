using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        //public ViewResult Overview()
        //    => View(new PlayListViewModel
        //    {
        //        PlayLists = repository.PlayLists
        //        .OrderBy(p => p.TimeSlotId)
        //    });

        public async Task<IActionResult> Index()
        {
            return View(await repository.FindAllAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
