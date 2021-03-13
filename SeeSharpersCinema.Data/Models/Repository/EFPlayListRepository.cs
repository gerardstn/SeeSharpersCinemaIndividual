using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Program;
using System;
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

        public async Task<IEnumerable<PlayList>> FindAllAsync()
            => await context.PlayLists
            .Include(b => b.Movie)
            .Include(c => c.TimeSlot)
            .OrderBy(p => p.TimeSlot.SlotStart)
            .ThenBy(q => q.TimeSlot.RoomId)
            .ToListAsync();

        public async Task<IEnumerable<PlayList>> FindBetweenDatesAsync(DateTime startDate, DateTime endDate)
            => await context.PlayLists
            .Include(b => b.Movie)
            .Include(c => c.TimeSlot)
            .OrderBy(p => p.TimeSlot.SlotStart)
            .ThenBy(q => q.TimeSlot.RoomId)
            .Where(z => z.TimeSlot.SlotStart.Date >= startDate && z.TimeSlot.SlotStart.Date <= endDate)
            .ToListAsync();

        public async Task<IEnumerable<PlayList>> FindByTitle(DateTime startDate, DateTime endDate, string uiTitle)
            => await context.PlayLists
            .Include(b => b.Movie)
            .Include(c => c.TimeSlot)
            .OrderBy(p => p.TimeSlot.SlotStart)
            .ThenBy(q => q.TimeSlot.RoomId)
            .Where(z => z.TimeSlot.SlotStart.Date >= startDate && z.TimeSlot.SlotStart.Date <= endDate && z.Movie.Title.Contains(uiTitle))
            .ToListAsync();

        public async Task<IEnumerable<PlayList>> FindByDate(DateTime uiDate)
            => await context.PlayLists
            .Include(b => b.Movie)
            .Include(c => c.TimeSlot)
            .OrderBy(p => p.TimeSlot.SlotStart)
            .ThenBy(q => q.TimeSlot.RoomId)
            .Where(z => z.TimeSlot.SlotStart.Date == uiDate)
            .ToListAsync();


        // TODO FIND TITLE AND DATE
        // TODO FIND BY GENRE: HARDCODED DROPDOWN
        //public async Task<IEnumerable<PlayList>> FindByTitleAndDate(string uiTitle, DateTime uiDate)
        //    => await context.PlayLists
        //    .Include(b => b.Movie)
        //    .Include(c => c.TimeSlot)
        //    .OrderBy(p => p.TimeSlot.SlotStart)
        //    .ThenBy(q => q.TimeSlot.RoomId)
        //    .Where(z => z.TimeSlot.SlotStart.Date == uiDate && z.Movie.Title.Contains(uiTitle))
        //    .ToListAsync();

    }
}
