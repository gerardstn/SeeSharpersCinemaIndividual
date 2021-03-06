using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models;
using SeeSharpersCinema.Models.ViewModel;
using System.Linq;

namespace SeeSharpersCinema.Controllers
{
    public class MoviesController : Controller
    {
        private ICinemaRepository repository;

        public MoviesController(ICinemaRepository repo)
        {
            repository = repo;
        }

        public ViewResult Overview()
            => View(new MovieListViewModel
            {
                Movies = repository.Movies
                .OrderBy(p => p.Title)
            });
    }
}
