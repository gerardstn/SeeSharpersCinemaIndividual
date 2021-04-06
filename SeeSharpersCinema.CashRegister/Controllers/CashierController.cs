using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.CashRegister.Controllers
{
    public class CashierController : Controller
    {
        [Authorize(Roles = "Cashier, Admin")]
        public IActionResult Overview()
        {
            return View();
        }
    }
}
