using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
