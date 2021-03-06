using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Program;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public class EFPlayListRepository : IPlayListRepository
    {
        private CinemaDbContext context;

        public EFPlayListRepository(CinemaDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<PlayList> PlayLists => context.PlayLists;
         
    }
}
