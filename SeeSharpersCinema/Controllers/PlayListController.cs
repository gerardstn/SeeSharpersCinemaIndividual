using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Models.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Controllers
{
    public class PlayListController : Controller
    {
        private IPlayListRepository repository;

        public PlayListController(IPlayListRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Overview()
        //    => View(new PlayListViewModel
        //    {
        //        PlayLists = repository.PlayLists
        //        .OrderBy(p => p.TimeSlotId)
        //    });

        public async Task<IActionResult> Overview()
        {
            return View(await repository.FindAllAsync());
        }
    }
}
