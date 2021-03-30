using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SeeSharpersCinema.CashRegister.Controllers
{
    [Authorize(Roles = "Admin,Cashier")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cashier()
        {
            return View();
        }

    }
}
