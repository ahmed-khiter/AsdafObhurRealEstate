using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.Account;
using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Services.AccountManagement
{
    public class AccountService
    {


        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;
        private readonly FileManager _fileManager;
        private readonly SignInManager<BaseUser> _signInManager;

        public AccountService(AsdafObhurContext context, 
            UserManager<BaseUser> userManager, 
            FileManager fileManager,
            SignInManager<BaseUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _fileManager = fileManager;
            _signInManager = signInManager;
        }

        public async Task<bool> AddRolesToUseService(AccountType accountType, BaseUser user)
        {
            return await AddRolesToUse(accountType, user);

        }

        public async Task<List<BasicDetailsUser>> SearcUser(string userNameOrCode)
        {
            if (!string.IsNullOrEmpty(userNameOrCode))
            {
                int code = 0;
                var ifIsCode = int.TryParse(userNameOrCode, out code);

                var users = await _userManager.Users
                    .Include(m => m.Department)
                    .Where(m => m.Code == code ||
                    m.FirstName.Contains(userNameOrCode) || m.LastName.Contains(userNameOrCode))
                    .Select(m => new BasicDetailsUser
                    {
                        id = m.Id,
                        code = m.Code,
                        fullName = $"{m.FirstName} {m.LastName}",
                        phoneNumber = m.PhoneNumber,
                    })
                    .ToListAsync();

                return users;
            }
            else
            {
                var users = await _userManager.Users
                    .Select(m => new BasicDetailsUser
                    {
                        id = m.Id,
                        code = m.Code,
                        fullName = $"{m.FirstName} {m.LastName}",
                        phoneNumber = m.PhoneNumber,
                    }).ToListAsync();

                return users;

            }
        }
         

        public async Task DeleteAccount(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var rolesForUser = await _userManager.GetRolesAsync(user);

            using (var transaction = _context.Database.BeginTransaction())
            {


                if (rolesForUser.Count() > 0)
                {
                    foreach (var item in rolesForUser.ToList())
                    {
                        // item should be the name of the role
                        var result = await _userManager.RemoveFromRoleAsync(user, item);
                    }
                }

                await _userManager.DeleteAsync(user);
                transaction.Commit();
            }
        }

        public async Task<EmployeeAndHisClients> DetailsOfEmployee(string userId)
        {


            var user = await _userManager.FindByIdAsync(userId);


            var employeeCreatedClient = await _context.Clients
                .Where(m => m.CreatedBy == user.Id).ToListAsync();


            var employeeHandledClient = await _context.Clients
                .Where(m => m.BaseUserId == user.Id).ToListAsync();

            var wholeDetails = new EmployeeAndHisClients()
            {
                Email = user.Email,
                From = DateTime.Now,
                To = DateTime.Now,
                EmployeeCode = user.Code,
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
                    ClientCode = item.Code,
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
                    ClientCode = item.Code,
                    ClientId = item.Id,
                    Name = item.ClientName,
                    Status = item.ClientStatus
                });
            }

            return wholeDetails;

        }

        private async Task<bool> AddRolesToUse(AccountType accountType, BaseUser user)
        {
            if (accountType == AccountType.GeneralManager)
                await _userManager.AddToRoleAsync(user, Role.GeneralManager);
            else if (accountType == AccountType.ProjectSupervisor)
                await _userManager.AddToRoleAsync(user, Role.ProjectSupervisor);
            else if (accountType == AccountType.ExecutiveSecretary)
                await _userManager.AddToRoleAsync(user, Role.ExecutiveSecretary);
            else if (accountType == AccountType.Personnel)
                await _userManager.AddToRoleAsync(user, Role.Personnel);
            else if (accountType == AccountType.marketing)
                await _userManager.AddToRoleAsync(user, Role.Marketing);
            else if (accountType == AccountType.ProjectMonitor)
                await _userManager.AddToRoleAsync(user, Role.ProjectMonitor);
            else if (accountType == AccountType.projectsEngineer)
                await _userManager.AddToRoleAsync(user, Role.ProjectsEngineer);
            else if (accountType == AccountType.Financial)
                await _userManager.AddToRoleAsync(user, Role.Financial);
            else
                return false;

            return true;

        }
    }
}
