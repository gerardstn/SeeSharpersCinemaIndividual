using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System.Linq;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class MoviesController : Controller
    {
        private IMovieRepository repository;

        /// <summary>
        /// MoviesController constructor
        /// </summary>
        /// <param name="repo">Constructor needs an IMovieRepository object</param>
        public MoviesController(IMovieRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Gete the view Overview
        /// </summary>
        /// <returns>A view with all the movies from the repository ordered by id</returns>
        public ViewResult Overview()
            => View(new MovieListViewModel
            {
                Movies = repository.Movies
                .OrderBy(p => p.Id)
            });
    }
}
