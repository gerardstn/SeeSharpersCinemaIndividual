using SeeSharpersCinema.Data.Models.Program;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Data.Models.Repository
{
    public interface IReservedSeatRepository: IRepository<ReservedSeat>
    {
        //IQueryable<ReservedSeat> ReservedSeat { get; }
        
    }
}
