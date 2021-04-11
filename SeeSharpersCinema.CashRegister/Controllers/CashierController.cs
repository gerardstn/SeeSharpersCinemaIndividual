using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Infrastructure;
using SeeSharpersCinema.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.CashRegister.Controllers
{
    [Authorize(Roles = "Admin,Cashier")]
    public class CashierController : Controller
    {

        private IPlayListRepository repository;

        public CashierController(IPlayListRepository repository)
        {
            this.repository = repository;
        }


        public async Task<IActionResult> MovieOverviewAsync()
        {
            var playlist = await repository.FindByDate(DateTime.Now.Date);
            return View(playlist);
        }

    }
}

