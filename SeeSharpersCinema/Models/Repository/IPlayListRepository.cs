using SeeSharpersCinema.Models.Program;
using System.Linq;

namespace SeeSharpersCinema.Models.Repository
{
    public interface IPlayListRepository
    {
        IQueryable<PlayList> PlayLists { get; }
    }
}
