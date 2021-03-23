﻿using SeeSharpersCinema.Data.Models.Program;
using SeeSharpersCinema.Models.Theater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using SeeSharpersCinema.Data.Program;

namespace SeeSharpersCinema.Data.Infrastructure
{
    public static class JSONSeatingHelper
    {
        /// <summary>
        /// Creates a JSON objectstring to render the reserved Seats in the view
        /// </summary>
        /// <param name="Room">A Room of type Room.</param>
        /// <param name="Seats">A list of type ReservedSeat.</param>
        /// <returns>A JSON string to the ViewModel</returns>
        public static string JSONSeating(Room Room, List<ReservedSeat> Seats)
        {
            List<ObjRow> ObjRowList = new List<ObjRow>();
            for (var j = 1; j <= Room.Rows; j++)
            {
                List<ObjSeat> objSeatList = new List<ObjSeat>();
                for (var i = 1; i <= (Room.Capacity / Room.Rows); i++)
                {

                    ObjSeat ObjSeat = new ObjSeat { GridSeatNum = i, seatNumber = i, SeatStatus = "0" };
                    var seatTaken = 0;
                    Seats.ForEach(s => {
                        if (s.SeatId == i & s.RowId == j & s.SeatState == SeatState.Reserved)
                        {
                            seatTaken = 1;
                        }
                        if (s.SeatId == i & s.RowId == j & s.SeatState == SeatState.Disabled)
                        {
                            seatTaken = 2;
                        }
                    });
                    if (seatTaken>0)//Todo think this can be integrated in seatTaken = true. Check later
                    {
                        ObjSeat.SeatStatus = seatTaken.ToString();
                        seatTaken = 0;
                    }

                    objSeatList.Add(ObjSeat);
                }
                ObjRow ObjRow = new ObjRow { GridRowId = j, PhyRowId = j.ToString(), objSeat = objSeatList };
                ObjRowList.Add(ObjRow);
            }

            ObjArea ObjArea = new ObjArea { AreaDesc = "EXECUTIVE", AreaCode = "0000000003", AreaNum = "1", HasCurrentOrder = true, objRow = ObjRowList };
            List<ObjArea> ObjAreaList = new List<ObjArea>();
            ObjAreaList.Add(ObjArea);


            ColAreas ColAreas = new ColAreas { Count = 1, intMaxSeatId = 21, intMinSeatId = 2, objArea = ObjAreaList };
            SeatLayout SeatLayout = new SeatLayout { colAreas = ColAreas };
            List<object> areaList = new List<object>();
            List<object> groupedSeatsList = new List<object>();

            Root Root = new Root
            {
                product_id = 46539040,
                freeSeating = false,
                tempTransId = "1ecae165f2d86315fea19963d0ded41a",
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
