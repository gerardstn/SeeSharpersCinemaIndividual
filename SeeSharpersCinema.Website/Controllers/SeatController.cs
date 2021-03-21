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

            //test all reserved seats
            var ReservedSeats = await seatRepository.FindAllByTimeSlotIdAsync(PlayList.TimeSlotId);

            //var Seats = ReservedSeats.Select(i => i.SeatId).ToList();
            var Seats = GetReservedSeats(ReservedSeats);

            //ViewData["ReservedSeats"] = Seats;
            ViewData["RoomCapacity"] = ReservedSeats.FirstOrDefault().TimeSlot.Room.Capacity;
            ViewData["PlaylistId"] = PlayList.Id;
            ViewData["ReservedSeats"] = Seats;
            //TimeSlotId = PlayList.TimeSlotId;
            //--------------------------------------------------------------------------------------------------
            SeatViewModel SeatViewModel = new SeatViewModel();
            SeatViewModel.Movie = PlayList.Movie;
            SeatViewModel.TimeSlot = PlayList.TimeSlot;
            SeatViewModel.SeatStates = new Dictionary<int, SeatState>();

            //add reservedseats & covid seats
            Seats.ForEach(s =>
            {
                SeatViewModel.SeatStates.Add(s, SeatState.Reserved);
                
                if (COVID == true)
                {
                    if (!Seats.Contains(s + 1) & !SeatViewModel.SeatStates.ContainsKey(s+1))
                    {
                        SeatViewModel.SeatStates.Add(s + 1, SeatState.Disabled);
                    }
                    if (!Seats.Contains(s - 1) & !SeatViewModel.SeatStates.ContainsKey(s - 1))
                    {
                        SeatViewModel.SeatStates.Add(s - 1, SeatState.Disabled);
                    }
                };
            });

            //--------------------------------------------------------------------------------------------------
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
                new ReservedSeat { SeatId = s, TimeSlotId = TimeSlotId }
                );
            });
            await seatRepository.ReserveSeats(ReservedSeat);

        }

        /// <summary>
        /// Gets the list of reserved seats from list
        /// </summary>
        private List<int> GetReservedSeats(IEnumerable<ReservedSeat> ReservedSeats)
        {
            var Seats = ReservedSeats.Select(i => i.SeatId).ToList();
            return Seats;

        }
    }
}
