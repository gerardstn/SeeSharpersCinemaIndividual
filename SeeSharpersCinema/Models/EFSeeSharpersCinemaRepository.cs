using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public class EFSeeSharpersCinemaRepository : ISeeSharpersCinemaRepository
    {
        private SeeSharpersDbContext context;

        public EFSeeSharpersCinemaRepository(SeeSharpersDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Ticket> Tickets => context.Tickets;

    }
}
