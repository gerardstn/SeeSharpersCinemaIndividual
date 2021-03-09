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
        private IMovieRepository repository;
        public HomeController(IMovieRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(new MovieListViewModel
        {
            Movies = repository.Movies.OrderBy(p => p.Id)
        });

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Overview()
            => View(new MovieListViewModel
            {
                Movies = repository.Movies
                .OrderBy(p => p.Id)
            });

        //public async Task<IActionResult> Overview()
        //{
        //    return View(await repository.FindAllAsync());
        //}
    }
}
