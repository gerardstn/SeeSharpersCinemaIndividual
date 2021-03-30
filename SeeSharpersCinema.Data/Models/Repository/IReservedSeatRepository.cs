using SeeSharpersCinema.Models.Program;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{

    /// <summary>
    /// IReservedSeatRepository interface makes sure these methods are implemented
    /// in a tasks for correct threading
    /// </summary>
    /// <returns>IEnumerable<ReservedSeat> objects or ICollection<ReservedSeat> object</returns>
    public interface IReservedSeatRepository : IRepository<ReservedSeat>
    {
        public Task<IEnumerable<ReservedSeat>> FindAllByTimeSlotIdAsync(long TimeslotId);
        public Task ReserveSeats(ICollection<ReservedSeat> reservedSeat);
    }

}
