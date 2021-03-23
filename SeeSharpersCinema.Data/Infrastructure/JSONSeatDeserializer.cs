using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Data.Models.Program
{
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
