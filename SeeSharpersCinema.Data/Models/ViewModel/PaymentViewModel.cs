using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Theater;
using System.Collections.Generic;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class PaymentViewModel
    {
        public PlayList PlayList { get; set; }
        public Ticket Ticket { get; set; }
        public Coupon Coupon { get; set; }
    }
}
