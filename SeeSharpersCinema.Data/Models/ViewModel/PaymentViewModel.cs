using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class PaymentViewModel
    {
        public PlayList PlayList { get; set; }
        public Ticket Ticket { get; set; }
        public Coupon Coupon { get; set; }

    }
}
