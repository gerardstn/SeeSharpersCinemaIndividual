using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System.Threading.Tasks;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class PlayListController : Controller
    {
        private IPlayListRepository repository;

        /// <summary>
        /// PlayListController constructor
        /// </summary>
        /// <param name="repo">Constructor needs an IPlayListRepository object</param>
        public PlayListController(IPlayListRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Get the view Overview in a task for correct threading in the background
        /// </summary>
        /// <returns>Movie view with all movies from the repository</returns>
        public async Task<IActionResult> Overview()
        {
            return View(await repository.FindAllAsync());
        }
    }
}
