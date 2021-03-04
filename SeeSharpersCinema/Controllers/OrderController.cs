using Microsoft.AspNetCore.Mvc;

namespace SeeSharpersCinema.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
