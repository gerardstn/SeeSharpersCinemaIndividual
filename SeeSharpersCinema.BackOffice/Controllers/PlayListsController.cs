using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Program;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.BackOffice.Controllers
{
    [Authorize(Roles = "Admin,BackOffice")]
    public class PlayListsController : Controller
    {
        private readonly CinemaDbContext _context;

        public PlayListsController(CinemaDbContext context)
        {
            _context = context;
        }

        // GET: PlayLists
        public async Task<IActionResult> Index()
        {
            var cinemaDbContext = _context.PlayLists.Include(p => p.Movie).Include(p => p.TimeSlot);
            return View(await cinemaDbContext.ToListAsync());
        }

        // GET: PlayLists/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playList = await _context.PlayLists
                .Include(p => p.Movie)
                .Include(p => p.TimeSlot)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playList == null)
            {
                return NotFound();
            }

            return View(playList);
        }






        /*        public IActionResult Create()
                {
                    PopulateTimeSlotDropDownList();
                    return View();
                }
                private void PopulateTimeSlotDropDownList(object selectedDepartment = null)
                {
                    var departmentsQuery = from d in _context.TimeSlots
                                           orderby d.SlotStart
                                           select d;
                    ViewBag.TimeslotId = new SelectList(departmentsQuery.AsNoTracking(), "DepartmentID", "Name", selectedDepartment);
                }*/


        // GET: PlayLists/Create
        public IActionResult Create()
        {
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id");
            ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id");
            return View();
        }

        // POST: PlayLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TimeSlotId,MovieId")] PlayList playList)

        {
            if (ModelState.IsValid)
            {
                _context.Add(playList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", playList.MovieId);
            ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id", playList.TimeSlotId);
            return View(playList);
        }









        // GET: PlayLists/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playList = await _context.PlayLists.FindAsync(id);
            if (playList == null)
            {
                return NotFound();
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", playList.MovieId);
            ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id", playList.TimeSlotId);
            return View(playList);
        }

        // POST: PlayLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,TimeSlotId,MovieId")] PlayList playList)
        {
            if (id != playList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayListExists(playList.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MovieId"] = new SelectList(_context.Movies, "Id", "Id", playList.MovieId);
            ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id", playList.TimeSlotId);
            return View(playList);
        }







        // GET: PlayLists/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playList = await _context.PlayLists
                .Include(p => p.Movie)
                .Include(p => p.TimeSlot)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playList == null)
            {
                return NotFound();
            }

            return View(playList);
        }

        // POST: PlayLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var playList = await _context.PlayLists.FindAsync(id);
            _context.PlayLists.Remove(playList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayListExists(long id)
        {
            return _context.PlayLists.Any(e => e.Id == id);
        }
    }
}
