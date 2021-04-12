using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Order;
using System;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFPaymentRepository : IPaymentRepository
    {

        private CinemaDbContext context;

        public EFPaymentRepository(CinemaDbContext context)
        {
            this.context = context;
        }

        public Ticket AddTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return ticket;
        }

        public Ticket CompareCoupon(string type, string code)
        {
            throw new NotImplementedException();
        }

        /*       public async Task<Coupon> CompareCoupon(string type, string code)
                   => await context.Coupons
                   .Include(c => c.Coupon)
                   .Where(c => c.Coupon.Code == code)
                   .Where(c => c.Coupon.Type == type)
                   .Where(c => c.Coupon.IsActive == true)
                   .Get();*/

        public Ticket GetTicket(long Id)
        {
            return context.Tickets.Find(Id);
        }

        public Task GetTicket(long? id)
        {
            throw new NotImplementedException();
        }

        public Ticket SetPrice(double Price)
        {
            throw new NotImplementedException();
        }

        public Ticket Update(Ticket ticketChanges)
        {
            var cashier = context.Tickets.Attach(ticketChanges);
            Ticket.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ticketChanges;
        }

        public Ticket UpdateCoupon(Coupon couponChanges)
        {
            throw new NotImplementedException();
        }
    }
}