using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Data.Models.Program;
using SeeSharpersCinema.Data.Models.Theater;
using SeeSharpersCinema.Data.Models.Repository;
using SeeSharpersCinema.Models.Repository;
using SeeSharpersCinema.Data.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeeSharpersCinema.Data.Models.Static;
using Newtonsoft.Json;

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

        /// <summary>
        /// Selector creates SeatViewModel for the view
        /// </summary>
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
            //ReservedSeats.ToList().ForEach(s => SeatViewModel.SeatStates.Add(s.SeatId, s.SeatState));
            //
            //temp room rows, add rows to room

            await SaveSeatTest();
            //
            return View(SeatViewModel);
        }

        //todo remove once form is implemented
        public async Task SaveSeatTest()
        {

            List<Seat> List = new List<Seat>
            {
                new Seat{RowId = 1, SeatId = 3},
                new Seat{RowId = 1, SeatId = 4},
                new Seat{RowId = 2, SeatId = 7},
                new Seat{RowId = 2, SeatId = 8},
                new Seat{RowId = 3, SeatId = 9},
                new Seat{RowId = 3, SeatId = 10}

            };
            await SaveSeats(List);
        }

        /// <summary>
        /// SaveSeats puts the list of seat(Id)s gained form the seat selection in the seat repo context.
        /// todo redo covid selection/ reserved
        /// </summary>
        private async Task SaveSeats(List<Seat> Seats, long TimeSlotId= 3)
        {
            List<ReservedSeat> ReservedSeat = new List<ReservedSeat>();
            Seats.ForEach(s => {
                ReservedSeat.Add(
                new ReservedSeat 
                { 
                    SeatId = s.SeatId, 
                    RowId = s.RowId, 
                    TimeSlotId = TimeSlotId , 
                    SeatState = SeatState.Reserved
                });
            });

            await seatRepository.ReserveSeats(ReservedSeat);

        }

        

    }
}
