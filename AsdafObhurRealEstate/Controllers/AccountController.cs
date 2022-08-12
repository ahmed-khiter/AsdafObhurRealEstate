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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wkhtmltopdf.NetCore;

namespace AsdafObhurRealEstate.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<BaseUser> userManager;
        private readonly SignInManager<BaseUser> signInManager;
        private readonly AsdafObhurContext _context;
        private IGeneratePdf _generatePdf;

        public AccountController
        (
            UserManager<BaseUser> userManager,
            SignInManager<BaseUser> signInManager,
            AsdafObhurContext context,
            IGeneratePdf generatePdf
        )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
            _generatePdf = generatePdf;
        }
       
        [HttpGet]
        public async Task<IActionResult> Register(AccountType accountType)
        {
            var departments = await _context.Departments.ToListAsync();

            ViewData["departments"] = new SelectList(departments, "Id", "Name");

            var registerModel = new RegisterDTO()
            {
                AccountType = accountType,
            };

            return View(registerModel);
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
                CreatedBy = userManager.GetUserId(User),
                CreatedAt = DateTime.Now,
            };
            using (var transaction = _context.Database.BeginTransaction())
            {
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, true);

                    await AddRolesToUse(model.AccountType, user);

                    transaction.Commit();

                    ViewData["Success"] = "تم التسجيل مرحبا بك في أصداف أبحر العقارية";

                    return Redirect("/");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.Include(m => m.Department).ToListAsync();

            return View(users);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return BadRequest();
                }

                var user = await userManager.FindByIdAsync(id);
                var rolesForUser = await userManager.GetRolesAsync(user);

                using (var transaction = _context.Database.BeginTransaction())
                {
                   

                    if (rolesForUser.Count() > 0)
                    {
                        foreach (var item in rolesForUser.ToList())
                        {
                            // item should be the name of the role
                            var result = await userManager.RemoveFromRoleAsync(user, item);
                        }
                    }

                    await userManager.DeleteAsync(user);
                    transaction.Commit();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Report(FilterReportByUserDTO model)
        {
            var reportName = $"Report.pdf";

            var user = await userManager.FindByIdAsync(model.UserId);

            var employeeCreatedClient = await _context.Clients
                .Where(m => m.CreatedBy == model.UserId && m.CreatedAt >= model.From && m.CreatedAt <= model.To).ToListAsync();


            var employeeHandledClient = await _context.Clients
                .Where(m => m.BaseUserId == model.UserId && m.CreatedAt >= model.From && m.CreatedAt <= model.To).ToListAsync();


            var reportModel = new GenerateReportDTO()
            {
                EmployeeName = $"{user.FirstName} {user.LastName}",
                PhoneNumber = user.PhoneNumber,
                ClientsCreatedBy = new List<ReportData>(),
                ClientsHandledBy = new List<ReportData>()
            };

            foreach (var item in employeeCreatedClient)
            {
                reportModel.ClientsCreatedBy.Add(new ReportData(item));
            }

            foreach (var item in employeeHandledClient)
            {
                reportModel.ClientsHandledBy.Add(new ReportData(item));
            }

            var options = new ConvertOptions
             {
                 PageSize = Wkhtmltopdf.NetCore.Options.Size.A4,
                 PageMargins = new Wkhtmltopdf.NetCore.Options.Margins() { Bottom = 20, Left = 1, Right = 1, Top = 1 },
                 PageOrientation = Wkhtmltopdf.NetCore.Options.Orientation.Portrait,
             };


            _generatePdf.SetConvertOptions(options);

            var pdf = await _generatePdf.GetByteArray("Views/Account/generateReport.cshtml", reportModel);
            
            var pdfStream = new MemoryStream(pdf);

            return File(pdfStream, "APPLICATION/octet-stream", reportName);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsOfEmployee(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);


            var employeeCreatedClient = await _context.Clients
                .Where(m => m.CreatedBy == user.Id ).ToListAsync();


            var employeeHandledClient = await _context.Clients
                .Where(m => m.BaseUserId == user.Id ).ToListAsync();

            var wholeDetails = new EmployeeAndHisClients()
            {
                Email = user.Email,
                Name = $"{user.FirstName} {user.LastName}",
                PhoneNumber = user.PhoneNumber,
                UserId = user.Id,
                ClientsWhoCreated = new List<ClientDetailsDto>(),
                ClientsWhoHandled = new List<ClientDetailsDto>()
            };

            foreach (var item in employeeCreatedClient)
            {
                wholeDetails.ClientsWhoCreated.Add(new ClientDetailsDto
                {
                    PhoneNumber = item.PhoneNumber,
                    ClientId = item.Id,
                    Name = item.ClientName,
                    Status = item.ClientStatus
                });
            }


            foreach (var item in employeeHandledClient)
            {
                wholeDetails.ClientsWhoHandled.Add(new ClientDetailsDto
                {
                    PhoneNumber = item.PhoneNumber,
                    ClientId = item.Id,
                    Name = item.ClientName,
                    Status = item.ClientStatus
                });
            }


            return View(wholeDetails);
        }


        private async Task<bool> AddRolesToUse(AccountType accountType, BaseUser user)
        {
            if (accountType == AccountType.GeneralManager)
                await userManager.AddToRoleAsync(user, Role.GeneralManager);
            else if (accountType == AccountType.ProjectSupervisor)
                await userManager.AddToRoleAsync(user, Role.ProjectSupervisor);
            else if (accountType == AccountType.ExecutiveSecretary)
                await userManager.AddToRoleAsync(user, Role.ExecutiveSecretary);
            else if (accountType == AccountType.Personnel)
                await userManager.AddToRoleAsync(user, Role.Personnel);
            else if (accountType == AccountType.marketing)
                await userManager.AddToRoleAsync(user, Role.Marketing);
            else if (accountType == AccountType.ProjectMonitor)
                await userManager.AddToRoleAsync(user, Role.ProjectMonitor);
            else if (accountType == AccountType.projectsEngineer)
                await userManager.AddToRoleAsync(user, Role.ProjectsEngineer);
            else if (accountType == AccountType.Financial)
                await userManager.AddToRoleAsync(user, Role.Financial);
            else
                return false;

            return true;
        
        }
    }
}
