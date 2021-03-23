
using SeeSharpersCinema.Data.Program;
using SeeSharpersCinema.Models;
using SeeSharpersCinema.Models.Theater;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Data.Models.Program
{
    public class ReservedSeat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long TimeSlotId { get; set; }
        public int SeatId {get; set;}
        public int RowId { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public SeatState SeatState { get; set; }

    }
}
