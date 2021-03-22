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
using SeeSharpersCinema.Models.Theater;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Encodings.Web;
using System.Text.Unicode;

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
            //SeatViewModel.SeatStates = new Dictionary<int, SeatState>();
            //ReservedSeats.ToList().ForEach(s => SeatViewModel.SeatStates.Add(s.SeatId, s.SeatState));
            

            //todo reservedseats transform to jsonobject
            //temp room rows, add rows to room
            var Seats = ReservedSeats.ToList();
            var Seating = JSONSeating(PlayList.TimeSlot.Room, Seats);
            SeatViewModel.SeatingArrangement = JSONSeating(PlayList.TimeSlot.Room, Seats);
            //await SaveSeatTest();
            return View(SeatViewModel);
        }


        /// <summary>
        /// takes post input as List of reserved seats via binding and saves seats to db
        /// </summary>
        /*        [HttpPost]
                //[ValidateAntiForgeryToken]
                public async Task<IActionResult> ReserveSeats([Bind("SeatId,RowId,TimeSlotId")] List<ReservedSeat> Seat)
                {
                    if (ModelState.IsValid)
                    {
                        //await SaveSeats(Seat);
                        return RedirectToAction("Index", "Home");//needs to be payment view, for now index main.
                    }
                    return RedirectToAction("Selector", "Seat");
                }*/

                /// <summary>
        /// takes post input as string and saves seats to db
        /// </summary>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> ReserveSeats(string SeatingString = "12:1|13:1" , long TimeSlotId =2)//todo remove testdata
        {
            List<ReservedSeat> Seats = new List<ReservedSeat>();
            string[] preferedSeats = SeatingString.Split('|');
            preferedSeats.ToList().ForEach(s =>
            {
                var seatId = Int32.Parse(s.Split(":")[0]);
                var rowId = Int32.Parse(s.Split(":")[1]);
                ReservedSeat ReservedSeat = new ReservedSeat { SeatId = seatId, RowId = rowId , TimeSlotId = TimeSlotId};
                Seats.Add(ReservedSeat);
            });
            await SaveSeats(Seats);

            return RedirectToAction("Index", "Home");//needs to be payment view, for now index main.
        }


        //todo remove once form is implemented
        /*        public async Task SaveSeatTest()
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
                }*/


        /// <summary>
        /// SaveSeats puts the list of seat(Id)s gained form the seat selection in the seat repo context.
        /// todo redo covid selection/ reserved
        /// </summary>
        /*        private async Task SaveSeats(List<Seat> Seats, long TimeSlotId= 3)
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
                    //todo add covid seats
                    await seatRepository.ReserveSeats(ReservedSeat);

                }*/

        //tryout
        private async Task SaveSeats(List<ReservedSeat> Seats)
        {
            Seats.ForEach(s => {
                s.SeatState = SeatState.Reserved;
                });
            //todo add covid seats
            await seatRepository.ReserveSeats(Seats);

        }

        public string JSONSeating(Room Room, List<ReservedSeat> Seats)
        {
            List<ObjRow> ObjRowList = new List<ObjRow>();
            for (var j = 1; j <= Room.Rows ; j++)
            {
                List<ObjSeat> objSeatList = new List<ObjSeat>();
                for (var i = 1; i <= (Room.Capacity / Room.Rows); i++)
                {

                    ObjSeat ObjSeat = new ObjSeat { GridSeatNum = i, seatNumber = i, SeatStatus = "0"};
                    var seatTaken = false;
                    Seats.ForEach(s => {
                        if (s.SeatId == i & s.RowId == j)
                        {
                            seatTaken = true;
                        }
                        });
                    if (seatTaken)//Todo think this can be integrated in seatTaken = true. Check later
                    {
                        ObjSeat.SeatStatus = "1";
                    }

                    objSeatList.Add(ObjSeat);
                }
                ObjRow ObjRow = new ObjRow { GridRowId = j, PhyRowId = j.ToString(), objSeat = objSeatList };
                ObjRowList.Add(ObjRow);
            }

            ObjArea ObjArea = new ObjArea { AreaDesc = "EXECUTIVE", AreaCode = "0000000003", AreaNum ="1",HasCurrentOrder = true, objRow = ObjRowList };
            List<ObjArea> ObjAreaList = new List<ObjArea>();
            ObjAreaList.Add(ObjArea);


            ColAreas ColAreas = new ColAreas {Count = 1, intMaxSeatId = 21, intMinSeatId=2, objArea = ObjAreaList };
            SeatLayout SeatLayout = new SeatLayout {colAreas = ColAreas};
            List<object> areaList = new List<object>();
            List<object> groupedSeatsList = new List<object>();

            Root Root = new Root { 
                product_id = 46539040, 
                freeSeating = false,
                tempTransId= "1ecae165f2d86315fea19963d0ded41a", 
                seatLayout = SeatLayout,
                areas = areaList,
                groupedSeats = groupedSeatsList
            };

            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
            var encoderSettings = new TextEncoderSettings();
            encoderSettings.AllowCharacters('\u0022');
            encoderSettings.AllowRange(UnicodeRanges.BasicLatin);
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(encoderSettings),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(Root, options);
            // System.Diagnostics.Debug.WriteLine(jsonString);

            return jsonString;
        }
        

    }
}
