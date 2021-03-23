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
        /// <param name="playListId">The playListId given by the route.</param>
        /// <returns>SeatViewModel</returns>
        [Route("Seat/Selector/{playListId}")]
        public async Task<IActionResult> Selector([FromRoute] long playListId)
        {
            var PlayListList = await playListRepository.FindAllAsync();
            var PlayList = PlayListList.FirstOrDefault(p => p.Id == playListId);
            var ReservedSeats = await seatRepository.FindAllByTimeSlotIdAsync(PlayList.TimeSlotId);
                     
            SeatViewModel SeatViewModel = new SeatViewModel();
            SeatViewModel.Movie = PlayList.Movie;
            SeatViewModel.TimeSlot = PlayList.TimeSlot;

            var Seats = ReservedSeats.ToList();
            var Seating = JSONSeating(PlayList.TimeSlot.Room, Seats);
            SeatViewModel.SeatingArrangement = JSONSeating(PlayList.TimeSlot.Room, Seats);
          
            return View(SeatViewModel);
        }


        /// <summary>
        /// takes post input as JSONstring and saves seats to db
        /// </summary>
        /// <param name="Seatstring">The JSON string given back from the form in the Seat/Selector.</param>
        /// <param name="TimeSlotId">The id corresponding to a specific TimeSlot. This is given back from the form in the Seat/Selector.</param>
        /// <returns>SeatViewModel</returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> ReserveSeats(string Seatstring, long TimeSlotId)//todo remove testdata
        {
            var SeatingArrangement = JsonSerializer.Deserialize<DeserializeRoot>(Seatstring);

            //System.Diagnostics.Debug.WriteLine(Seatstring);
            List<ReservedSeat> SeatList = new List<ReservedSeat>();
            SeatingArrangement.selected.ForEach(s =>
            {
                ReservedSeat ReservedSeat = new ReservedSeat { SeatId = s.seatNumber, RowId = s.GridRowId, TimeSlotId = TimeSlotId, SeatState=SeatState.Reserved };
                SeatList.Add(ReservedSeat);
            });

            //await SaveSeats(SeatList);
            await seatRepository.ReserveSeats(SeatList);
            return RedirectToAction("Index", "Home");//needs to be payment view, for now index main.*/

        }


        /// <summary>
        /// Creates a JSON objectstring to render the reserved Seats in the view
        /// </summary>
        /// <param name="Room">A Room of type Room.</param>
        /// <param name="Seats">A list of type ReservedSeat.</param>
        /// <returns>A JSON string to the ViewModel</returns>
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
