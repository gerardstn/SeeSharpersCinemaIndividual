using SeeSharpersCinema.Models.Website;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public interface INoticeRepository
    {
        IQueryable<Notice> Notices { get; }

        public Task<IEnumerable<Notice>> FindFirstNotice();
    }
}
