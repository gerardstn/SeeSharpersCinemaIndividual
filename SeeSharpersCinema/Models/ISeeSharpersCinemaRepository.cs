using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public interface ISeeSharpersCinemaRepository
    {
        IQueryable<Ticket> Tickets { get; }
    }
}
