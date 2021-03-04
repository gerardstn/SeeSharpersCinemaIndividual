using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models;

namespace SeeSharpersCinema.Controllers
{
    public class OrderController : Controller
    {
        private ICinemaRepository repository;

        public OrderController(ICinemaRepository repo)
        {
            repository = repo;
        }

        public IActionResult MoviesNow() => View(repository.Movies);
    }
}
