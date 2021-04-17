using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Coupon> CompareCoupon(string type, string code)
            => await context.Coupons
            .Where(c => c.Code == code && c.Type == type)
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<Coupon>> FindAllAsync()
              => await context.Coupons
            .ToListAsync();
    }
}