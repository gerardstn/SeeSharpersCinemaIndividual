using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Program;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFPlayListRepository : IPlayListRepository
    {
        private CinemaDbContext context;

        public EFPlayListRepository(CinemaDbContext ctx)
        {
            context = ctx;
        }

        // public IQueryable<PlayList> PlayLists => context.PlayLists;

        public async Task<IEnumerable<PlayList>> FindAllAsync()
            => await context.PlayLists
            .Include(b => b.Movie)
            .Include(c => c.TimeSlot)
            .OrderBy(p => p.TimeSlot.SlotStart)
            .ThenBy(q => q.TimeSlot.RoomId)
            .ToListAsync();
    }
}
