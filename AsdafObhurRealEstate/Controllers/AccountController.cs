using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.Account;
using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<BaseUser> userManager;
        private readonly SignInManager<BaseUser> signInManager;
        private readonly AsdafObhurContext _context;

        public AccountController
        (
            UserManager<BaseUser> userManager,
            SignInManager<BaseUser> signInManager,
            AsdafObhurContext context
        )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
        }
       
        [HttpGet]
        public IActionResult Register(AccountType accountType)
        {
            ViewData["accountType"] = accountType;
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            if (signInManager.IsSignedIn(User))
            {
                return Redirect("/");
            }

            if((int)model.AccountType <= 0 || (int)model.AccountType > 8)
            {
                    return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var currentUser = await userManager.FindByEmailAsync(model.Email);

            if (currentUser != null)
            {
                ModelState.AddModelError("Email", "Email is already exists");

                return View(model);
            }

            var user = new BaseUser
            {
                AccountType = model.AccountType,
                Email = model.Email,
                UserName = model.Email,
                FirstName = model.FirstName, 
                LastName = model.LastName ,
                EmailConfirmed = true,
                PhoneNumber = model.Phonenumber,
                NormalizedEmail = model.Email.ToUpper(),
                NormalizedUserName = model.Email.ToUpper(),
                CreatedBy = "Admin",
                CreatedAt = DateTime.Now,
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, true);
                await userManager.AddToRoleAsync(user, Role.GeneralManager);

                ViewData["Success"] = "تم التسجيل مرحبا بك في أصداف أبحر العقارية";

                return Redirect("/");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var currentUser = await userManager.FindByEmailAsync(model.Email);

            if (currentUser == null)
            {
                ModelState.AddModelError(string.Empty, "البريد الالكتروني او الرقم السري خطأ برجاء المحاوله مره اخرى");

                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(currentUser, model.Password, isPersistent: model.RememberMe, lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "البريد الالكتروني او الرقم السري خطأ برجاء المحاوله مره اخرى");

                return View(model);
            }
            ViewData["Success"] = "تم التسجيل مرحبا بك في أصداف أبحر العقارية";
            return Redirect("/");
        }

        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("/");
        }

        [Authorize(Roles = Role.GeneralManager)]
        public IActionResult Consumers()
        {
            var test = userManager.Users.Where(m => m.AccountType.Equals(AccountType.GeneralManager));
            return View(test);
        }

        [Authorize(Roles = Role.GeneralManager)]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.Include(m => m.Department).ToListAsync();

            return View(users);
        }

    }
}
