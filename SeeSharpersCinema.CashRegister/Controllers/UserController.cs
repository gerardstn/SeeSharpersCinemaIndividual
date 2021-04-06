using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeeSharpersCinema.Models.ViewModel;
using System.Threading.Tasks;


namespace SeeSharpersCinema.CashRegister.Controllers
{

    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult AccesDenied()
        {
            return RedirectToAction("NotAllowed", "User");
        }

        public IActionResult NotAllowed()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Microsoft.AspNetCore.Identity.SignInResult result
                    = await _signInManager.PasswordSignInAsync(
                        model.UserName,
                        model.Password,
                        isPersistent: false,
                        lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("MovieOverview", "Cashier");
                }
                ModelState.AddModelError("", "Login failed.");
            }
            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "User");
        }


    }
}

