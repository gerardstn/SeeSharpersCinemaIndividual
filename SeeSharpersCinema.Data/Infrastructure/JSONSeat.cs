using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Data.Models.Program
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ObjSeat
    {
        public int GridSeatNum { get; set; }
        public string SeatStatus { get; set; }
        public int seatNumber { get; set; }
    }

    public class ObjRow
    {
        public int GridRowId { get; set; }
        public string PhyRowId { get; set; }
        public List<ObjSeat> objSeat { get; set; }
    }

    public class ObjArea
    {
        public string AreaDesc { get; set; }
        public string AreaCode { get; set; }
        public string AreaNum { get; set; }
        public bool HasCurrentOrder { get; set; }
        public List<ObjRow> objRow { get; set; }
    }

    public class ColAreas
    {
        public int Count { get; set; }
        public int intMaxSeatId { get; set; }
        public int intMinSeatId { get; set; }
        public List<ObjArea> objArea { get; set; }
    }

    public class SeatLayout
    {
        public ColAreas colAreas { get; set; }
    }

    public class Root
    {
        public int product_id { get; set; }
        public bool freeSeating { get; set; }
        public string tempTransId { get; set; }
        public SeatLayout seatLayout { get; set; }
        public List<object> areas { get; set; }
        public List<object> groupedSeats { get; set; }
    }

    public class Selected
    {
        public int GridSeatNum { get; set; }
        public string SeatStatus { get; set; }
        public int seatNumber { get; set; }
        public int GridRowId { get; set; }
        public string PhyRowId { get; set; }
        public string AreaNum { get; set; }
        public string AreaCode { get; set; }
        public string AreaDesc { get; set; }
    }

    public class DeserializeRoot
    {
        public List<Selected> selected { get; set; }
    }

}
