using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Data.Models.Repository;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Website.Controllers
{
    public class SeatController : Controller
    {

        private IPlayListRepository playListRepository;
        private IReservedSeatRepository seatRepository;

        public SeatController(IPlayListRepository playListRepository, IReservedSeatRepository seatRepository)
        {
            this.playListRepository = playListRepository;
            this.seatRepository = seatRepository;
        }

        [Route("Seat/Selector/{playListId}")]
        public async Task<IActionResult> Selector([FromRoute] long playListId)
        {

            /*var selectedPlayList = repository.PlayList.FirstOrDefault(m => m.Id == movieId);
                        if (selectedMovie == null)
                        {
                            return NotFound();
                        }

                        Ticket ticket = new Ticket()
                        {
                            Movie = selectedMovie
                        };
                        return View(ticket);*/

            var PlayListList = await playListRepository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == playListId);

            return View(PlayList);
        }

    }
}
