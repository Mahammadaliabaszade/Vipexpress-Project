using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vipexfinal.Models;
using Vipexfinal.ViewModel;

namespace Vipexfinal.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _singinManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> singinManager)
        {
            _userManager = userManager;
            _singinManager = singinManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVm register)
        {

            if (!ModelState.IsValid) return View();

            Random rnd = new Random();
            int randomint = rnd.Next(1, 20000);
            AppUser user = new AppUser
            {
                FullName = register.FullName,
                UserName = register.UserName,
                Email = register.Email,
                MusteriKod=randomint
                
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _singinManager.SignInAsync(user, false);
            return RedirectToAction("Index", "Hesab");

        }

        public async Task<IActionResult> Logout()
        {
            await _singinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVm login)
        {
            
            if (!ModelState.IsValid) return View();

            AppUser signinuser = await _userManager.FindByEmailAsync(login.Email);
            if (signinuser == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View();
            }
          

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                await _singinManager.PasswordSignInAsync(signinuser, login.Password, login.IsPersistent, true);

            if (signInResult.IsLockedOut)
            {

                ModelState.AddModelError("", "Try again a few minute later");
                return View();
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Try again a few minute later");
                return View();
            }

            TempData["ID"] = signinuser.Id;
            return RedirectToAction("Index","Hesab");
        }

    }
}
