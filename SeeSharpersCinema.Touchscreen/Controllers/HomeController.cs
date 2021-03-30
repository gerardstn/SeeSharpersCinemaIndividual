using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeeSharpersCinema.Models;
using System.Diagnostics;
using SeeSharpersCinema.Models.ViewModel;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// HomeController constructor
        /// </summary>
        /// <param name="logger">Constructor needs a Ilogger<HomeController> object</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get the view Index
        /// </summary>
        /// <returns>Redirect action to view Overview from controller PlayList</returns>
        public IActionResult Index()
        {
            return RedirectToAction("Overview", "Playlist");
        }

        /// <summary>
        /// Get the view Error
        /// </summary>
        /// <returns>A view with errormessages</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
