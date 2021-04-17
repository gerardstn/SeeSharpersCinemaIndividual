using SeeSharpersCinema.Models.Order;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPaymentRepository : IRepository<Coupon>    
    {
        public Ticket AddTicket(Ticket ticket);
        public Task<Coupon> CompareCoupon(string type, string code);
    }
}
