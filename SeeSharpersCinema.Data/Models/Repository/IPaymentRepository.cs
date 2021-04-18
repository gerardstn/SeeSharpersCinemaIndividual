using SeeSharpersCinema.Models.Order;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPaymentRepository : IRepository<Coupon>
    {
        public Ticket AddTicket(Ticket ticket);
        public Ticket GetTicket(long Id);
        public Task<Coupon> CompareCoupon(string type, string code);
        public Task<Coupon> GetCoupon(string code);
    }
}
