using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.Core;
using AsdafObhurRealEstate.DTO.Account;
using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using AsdafObhurRealEstate.Services.AccountManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wkhtmltopdf.NetCore;

namespace AsdafObhurRealEstate.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<BaseUser> userManager;
        private readonly SignInManager<BaseUser> signInManager;
        private readonly AsdafObhurContext _context;
        private IGeneratePdf _generatePdf;

        private readonly AccountService _accountService;

        public AccountController
        (
            UserManager<BaseUser> userManager,
            SignInManager<BaseUser> signInManager,
            AsdafObhurContext context,
            AccountService accountService,
            IGeneratePdf generatePdf
        )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _context = context;
            _generatePdf = generatePdf;
            _accountService = accountService;
        }
       
        [HttpGet]
        [Authorize(Roles = Role.GeneralManager)]
        public async Task<IActionResult> Register(AccountType accountType)
        {
            var departments = await _context.Departments.ToListAsync();

            User.FindFirst("fullName");
            ViewData["departments"] = new SelectList(departments, "Id", "Name");

            var registerModel = new RegisterDTO()
            {
                AccountType = accountType,
            };

            return View(registerModel);
        }
       
        [HttpPost]
        [Authorize(Roles = Role.GeneralManager)]
        public async Task<IActionResult> Register(RegisterDTO model)
        {
            var currentUserIsValidOrNot = await userManager.FindByIdAsync(userManager.GetUserId(User));

            if (signInManager.IsSignedIn(User))
            {
                if(!await userManager.IsInRoleAsync(currentUserIsValidOrNot, Role.GeneralManager))
                {
                    return Redirect("/");
                }
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
                ModelState.AddModelError("Email", "الإيميل او الرقم المرور غير صحيح");

                return View(model);
            }

            var code = await userManager.Users.MaxAsync(m => m.Code) + 1;

            var user = new BaseUser
            {
                AccountType = model.AccountType,
                Code = code,
                Email = model.Email,
                UserName = model.Email,
                FirstName = model.FirstName, 
                LastName = model.LastName ,
                EmailConfirmed = true,
                PhoneNumber = model.Phonenumber,
                NormalizedEmail = model.Email.ToUpper(),
                NormalizedUserName = model.Email.ToUpper(),
                CreatedBy = userManager.GetUserId(User),
                DepartmentId = model.DepartmentId,
                CreatedAt = DateTime.Now,
            };
            using (var transaction = _context.Database.BeginTransaction())
            {
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _accountService.AddRolesToUseService(model.AccountType, user);

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
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
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

        [Authorize]
        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();
            return Redirect("/");
        }


        [Authorize(Roles = Role.GeneralManager)]
        [HttpGet]
        public async Task<IActionResult> SearchUser(string userName)
        {
            var users = await _accountService.SearcUser(userName);

            return Ok(users);
        }


        [Authorize(Roles = Role.GeneralManager)]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.Include(m => m.Department).ToListAsync();
            return View(users);
        }

        [HttpPost]
        [Authorize(Roles = Role.GeneralManager)]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return BadRequest();
                }

                await _accountService.DeleteAccount(id);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [Authorize(Roles = Role.GeneralManager)]
        public async Task<IActionResult> Report(GenerateReportDTO model)
        {
            var reportName = $"Report.pdf";

            var user = await userManager.FindByIdAsync(model.UserId);

            var employeeCreatedClient = await _context.Clients
                .Where(m => m.CreatedBy == model.UserId && m.CreatedAt >= model.From && m.CreatedAt <= model.To).ToListAsync();


            var employeeHandledClient = await _context.Clients
                .Where(m => m.BaseUserId == model.UserId && m.CreatedAt >= model.From && m.CreatedAt <= model.To).ToListAsync();

            var baseUrl = $"{Request.Scheme}://{Request.Host.Value}/";

            var reportModel = new GenerateReportDTO()
            {
                BaseUrl = baseUrl,
                Name = $"{user.FirstName} {user.LastName}",
                EmployeeCode = model.EmployeeCode,
                Email = model.Email,
                From = model.From,
                To  = model.To,
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

            var pdf = await _generatePdf.GetByteArray($"Views/Account/Report.cshtml", reportModel);
            
            var pdfStream = new MemoryStream(pdf);

            return File(pdfStream, "APPLICATION/octet-stream", reportName);
        }

        [HttpGet]
        [Authorize(Roles = Role.GeneralManager)]
        public async Task<IActionResult> DetailsOfEmployee(string userId)
        {
            var details = await _accountService.DetailsOfEmployee(userId);

            return View(details);
        }


        [HttpGet]
        public async Task<IActionResult> PaginationEmployees(QueryParameters param)
        {
            // Get all clients as collection of queryable
            var query = userManager.Users.OrderBy(m => m.Code).AsQueryable();
            var count = await query.CountAsync();
            var items = await query.Skip((param.Page) * param.Limit).Take(param.Limit).ToListAsync();
            var resultPageList = new PagedList<BaseUser>(items, count, param.Page, param.Limit);

            var output = new PagedListModel<GenericListItemDTO>
            {
                Data = resultPageList.Select(c => new GenericListItemDTO(c)).ToList(),
                Page = param.Page,
                Limit = param.Limit,
                Length = resultPageList.TotalCount,
                //Pages = pages.TotalPages
            };
            return Ok(output);
        }

        [HttpGet]
        public IActionResult ChangePassword() => View();

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassword model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!model.NewPassword.Equals(model.ConfirmPassword))
            {
                ModelState.AddModelError("", "الرقم السري الجديد لا يطابق تاكيد الرقم السري");
                return View();
            }

            var userId = userManager.GetUserId(User);
            var user = await userManager.FindByIdAsync(userId);


            var result = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (result.Succeeded)
            {
                return Redirect("/");
            }
            else
            {
                ModelState.AddModelError("", "الرقم السري القديم خاطئ جرب مره اخرى.");
            }

            return View(model);


        }

    }
}
