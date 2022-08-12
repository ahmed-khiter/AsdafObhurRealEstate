using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.Home;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AsdafObhurRealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;

        public HomeController(ILogger<HomeController> logger,
            AsdafObhurContext context, UserManager<BaseUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Tables()
        {
            var user = await _userManager.GetUserAsync(User);

            var userIsGeneralManager = await _userManager.IsInRoleAsync(user, Role.GeneralManager);

            List<BaseUser> employees = new List<BaseUser>();
            ViewData["isGeneralManager"] = userIsGeneralManager;

            if(userIsGeneralManager)
                 employees.AddRange(await _userManager.Users.ToListAsync());


            List<Client> clients = new List<Client>();

            if (userIsGeneralManager)
            {
                clients.AddRange(await _context.Clients.ToListAsync());
            }
            else
            {
                clients.AddRange(await _context.Clients.Where(m => m.BaseUserId == user.Id).ToListAsync());

            }

            var allTables = new TablesDTO()
            {
                Clients = new List<EmployeeAndClient>(),
                Employees = new List<EmployeeAndClient>(),

            };
            if (userIsGeneralManager)
            {
                foreach (var item in employees)
                {
                    allTables.Employees.Add(new EmployeeAndClient()
                    {
                        Id = item.Id,
                        Name = $"{item.FirstName} {item.LastName}",
                        PhoneNumber = item.PhoneNumber,
                    
                    });
                }
            }

            foreach (var item in clients)
            {
                allTables.Clients.Add(new EmployeeAndClient()
                {
                    Id = item.Id,
                    Name = $"{item.ClientName}",
                    PhoneNumber = item.PhoneNumber,
                    Status = item.ClientStatus

                });
            }

            return View(allTables);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}