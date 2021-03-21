using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Data.Models.Program;
using SeeSharpersCinema.Data.Models.Repository;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Data.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Data.Models.Static;

namespace SeeSharpersCinema.Website.Controllers
{
    public class SeatController : Controller
    {

        private IPlayListRepository playListRepository;
        private IReservedSeatRepository seatRepository;
        //private long TimeSlotId;
        bool COVID = true;

        public SeatController(IPlayListRepository playListRepository, IReservedSeatRepository seatRepository)
        {
            this.playListRepository = playListRepository;
            this.seatRepository = seatRepository;
        }

        [Route("Seat/Selector/{playListId}")]
        public async Task<IActionResult> Selector([FromRoute] long playListId)
        {
            var PlayListList = await playListRepository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == playListId);

            var ReservedSeats = await seatRepository.FindAllByTimeSlotIdAsync(PlayList.TimeSlotId);

            //--------------------------------------------------------------------------------------------------
            SeatViewModel SeatViewModel = new SeatViewModel();
            SeatViewModel.Movie = PlayList.Movie;
            SeatViewModel.TimeSlot = PlayList.TimeSlot;
            SeatViewModel.SeatStates = new Dictionary<int, SeatState>();
            ReservedSeats.ToList().ForEach(s => SeatViewModel.SeatStates.Add(s.SeatId, s.SeatState));
            //add reservedseats & covid seats

            return View(SeatViewModel);
        }

        //todo remove once form is implemented
        public async Task SaveSeatTest()
        {
            List<int> List = new List<int> { 59, 60, 82, 83, 265, 266 };
            await SaveSeats(List, 3);
        }

        /// <summary>
        /// SaveSeats puts the list of seat(Id)s gained form the seat selection in the seat repo context
        /// </summary>
        private async Task SaveSeats(List<int> SeatId, long TimeSlotId)
        {
            List<ReservedSeat> ReservedSeat = new List<ReservedSeat>();
            SeatId.ForEach(s => {
                ReservedSeat.Add(
                new ReservedSeat 
                { 
                    SeatId = s, TimeSlotId = TimeSlotId , SeatState = SeatState.Reserved}
                );

                if (COVID)
                {
                    if (!SeatId.Contains(s - 1))
                    {
                        ReservedSeat.Add(
                        new ReservedSeat 
                        { 
                            SeatId = s, TimeSlotId = TimeSlotId, SeatState = SeatState.Disabled 
                        });
                    }

                    if (!SeatId.Contains(s + 1))
                    {
                        ReservedSeat.Add(
                        new ReservedSeat
                        { 
                            SeatId = s, TimeSlotId = TimeSlotId, SeatState = SeatState.Disabled }
                        );
                    }

                }
            });
            await seatRepository.ReserveSeats(ReservedSeat);

        }

    }
}
