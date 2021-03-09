using SeeSharpersCinema.Models.Program;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPlayListRepository : IRepository<PlayList>
    {
        // IQueryable<PlayList> PlayLists { get; }
    }
}
