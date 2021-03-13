using SeeSharpersCinema.Models.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPlayListRepository : IRepository<PlayList>
    {
        public Task<IEnumerable<PlayList>> FindBetweenDatesAsync(DateTime startDate, DateTime endDate);
        public Task<IEnumerable<PlayList>> FindByTitle(DateTime startDate, DateTime endDate, string titleString);
        public Task<IEnumerable<PlayList>> FindByDate(DateTime dateString);
    }
}
