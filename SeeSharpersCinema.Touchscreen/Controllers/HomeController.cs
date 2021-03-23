using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeeSharpersCinema.Models;
using System.Diagnostics;

namespace SeeSharpersCinema.TouchScreen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Overview", "Playlist");
        }

        /*        public IActionResult Privacy()
                {
                    SeeSharpersCinema.Models.EmailService emailService = new SeeSharpersCinema.Models.EmailService();
                    emailService.email_send();
                    return View();
                }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
