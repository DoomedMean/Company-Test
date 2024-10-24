using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleStore.Models;

namespace SimpleStore.Controllers
{
	public class LoginController : Controller
	{
		private readonly SignInManager<IdentityUser> _signInManager;
		private readonly UserManager<IdentityUser> _userManager;
        public LoginController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
			_signInManager = signInManager;
			_userManager = userManager;
        }
        public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(Login login)
		{
			if (!ModelState.IsValid)
			{
               return View(login);
			}

			var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, login.RememberMe, false);
			if (result.Succeeded)
			{
				return View();
			}
			else
			{
				TempData["error"] = "Cannot Login"; 
				ModelState.AddModelError("", "Invalid Login");
				return View();
			}
		}

        public IActionResult Register()
		{
			return View();
        }

		// POST: /Account/Register
		[HttpPost]
        public async Task<IActionResult> Register(Register register)
		{
			if (ModelState.IsValid)
			{
                var user = new IdentityUser { UserName = register.Email, Email = register.Email };
				var result = await _userManager.CreateAsync(user, register.Password);

				if (result.Succeeded)
				{
                    await _signInManager.SignInAsync(user, isPersistent: false);
					return RedirectToAction("Login", "Login");
				}
				else
				{
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(register);
		}


		[HttpPost]
		public async Task<IActionResult> Logout()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Login", "Login");
		}
	}
}
