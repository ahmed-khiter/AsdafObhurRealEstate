﻿using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.Home;
using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;

namespace AsdafObhurRealEstate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;
        private readonly WhatsAppsSender _whatsAppsSender;

        public HomeController(ILogger<HomeController> logger,
            AsdafObhurContext context, UserManager<BaseUser> userManager, WhatsAppsSender whatsAppsSender)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _whatsAppsSender = whatsAppsSender;
        }

        public async Task<IActionResult> Index()
        {
            await _whatsAppsSender.SendMessage("احمد خالد", "201100811024", WhatsAppTemplate.EmployeeSendOpenFileToClient);
            return View();
        }

        [Authorize(Roles = Role.GeneralManager)]
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
                        Code = item.Code,
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
                    Code= item.Code,
                    PhoneNumber = item.PhoneNumber,
                    Status = item.ClientStatus.GetAttribute<DisplayAttribute>().Name,

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