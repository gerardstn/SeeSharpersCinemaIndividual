using SeeSharpersCinema.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPaymentRepository
    {
        Ticket AddTicket(Ticket ticket);
        Ticket GetTicket(long Id);
        Ticket SetPrice(double Price);
        Ticket CompareCoupon(Coupon coupon);
        Ticket UpdateCoupon(Coupon couponChanges);
        Ticket Update(Ticket ticketChanges);
        Task GetTicket(long? id);
    }
}
