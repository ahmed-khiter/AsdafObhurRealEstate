using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.ClientsDataTransferObject;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AsdafObhurRealEstate.Services.Clients
{
    public class ClientService
    {
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;
        private readonly FileManager _fileManager;
        public ClientService(AsdafObhurContext context, UserManager<BaseUser> userManager, FileManager fileManager)
        {
            _context = context;
            _userManager = userManager;
            _fileManager = fileManager;
        }

        public async Task<List<ListClientDTO>> GetClients(ClaimsPrincipal User,bool refreshPage)
        {
            var userId = _userManager.GetUserId(User);

            var user = await _userManager.FindByIdAsync(userId);

            if (await _userManager.IsInRoleAsync(user, Role.GeneralManager))
            {
                if (refreshPage)
                {
                    var rslt = await _context.Clients
                        .OrderBy(m => m.Code)
                        .Take(10)
                        .Select(m => new ListClientDTO
                    {
                        Id = m.Id,
                        ClientName = m.ClientName,
                        PhoneNumber = m.PhoneNumber,
                        Code = m.Code,
                        Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                        CreateAt = m.CreatedAt
                    }).ToListAsync();

                    return rslt;

                }

                return await _context.Clients
                        .OrderBy(m => m.Code)
                        .Take(10).Select(m => new ListClientDTO
                {
                    Id = m.Id,
                    ClientName = m.ClientName,
                    PhoneNumber = m.PhoneNumber,
                    Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                    Code = m.Code,
                    CreateAt = m.CreatedAt
                }).ToListAsync();
            }

            var clients = await _context.Clients.Where(m => m.BaseUserId == userId)
                        .OrderBy(m => m.Code)
                        .Take(10).Select(m => new ListClientDTO
            {
                Id = m.Id,
                ClientName = m.ClientName,
                PhoneNumber = m.PhoneNumber,
                Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                Code = m.Code,
                CreateAt = m.CreatedAt
            }).ToListAsync();

            if (refreshPage)
            {
                return clients;
            }

            return clients;

        }



    }
}
