using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Website.Controllers
{

    public class PaymentController : Controller
    {
        private IPlayListRepository repository;
        public PaymentController(IPlayListRepository repo)
        {
            repository = repo;
        }

        public async Task<IActionResult> Pay(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var PlayListList = await repository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == id);

            if (PlayList == null)
            {
                return NotFound();
            }

            return View(PlayList);
        }
    }
}

