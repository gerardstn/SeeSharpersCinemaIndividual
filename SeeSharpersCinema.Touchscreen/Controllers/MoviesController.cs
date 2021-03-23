using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System.Linq;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository repository;

        public MoviesController(IMovieRepository repo)
        {
            repository = repo;
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
