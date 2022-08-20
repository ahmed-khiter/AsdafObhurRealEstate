using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.ClientsDataTransferObject;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using AsdafObhurRealEstate.Services.Clients;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AsdafObhurRealEstate.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;
        private readonly FileManager _fileManager;
        private readonly WhatsAppsSender _whatsAppsSender;
        private readonly ClientService _clientService;
        public ClientController(AsdafObhurContext context, UserManager<BaseUser> userManager, ClientService clientService,
            WhatsAppsSender whatsAppsSender,
            FileManager fileManager)
        {
            _context = context;
            _userManager = userManager;
            _fileManager = fileManager;
            _clientService = clientService;
            _whatsAppsSender = whatsAppsSender;
        }

        [HttpGet]
        public async Task<IActionResult> Index(bool refreshPage, bool isJsonReturn)
        {
            var clients = await _clientService.GetClients(User, refreshPage);

            if (isJsonReturn)
                return Ok(clients);

            return View(clients);
        }


        [HttpGet]
        public async Task<IActionResult> SearchClient(string userNameOrCode, bool heCreated)
        {
            if (!string.IsNullOrEmpty(userNameOrCode))
            {
                int code = 0;
                var isNumber = int.TryParse(userNameOrCode, out code);

                var userId = _userManager.GetUserId(User);

                var user = await _userManager.FindByIdAsync(userId);

                if (await _userManager.IsInRoleAsync(user, Role.GeneralManager))
                {
                    return Ok(
                        await _context.Clients
                        .Where(m => m.Code == code || m.ClientName.Contains(userNameOrCode))
                        .Select(m => new ListClientDTO
                        {
                            Id = m.Id,
                            ClientName = m.ClientName,
                            PhoneNumber = m.PhoneNumber,
                            Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                            Code = m.Code,
                        })
                        .ToListAsync());
                }
                List<ListClientDTO> clients = new List<ListClientDTO>();

                if (heCreated)
                {
                    clients.AddRange(await _context.Clients.Where(m => (m.Code == code || m.ClientName
                       .Contains(userNameOrCode)) && m.CreatedBy == userId)
                             .Select(m => new ListClientDTO
                             {
                                 Id = m.Id,
                                 ClientName = m.ClientName,
                                 PhoneNumber = m.PhoneNumber,
                                 Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                 Code = m.Code,
                             })
                             .ToListAsync());
                }
                else
                {
                    clients.AddRange(await _context.Clients.Where(m => (m.Code == code || m.ClientName
                      .Contains(userNameOrCode)) && m.BaseUserId == userId)
                            .Select(m => new ListClientDTO
                            {
                                Id = m.Id,
                                ClientName = m.ClientName,
                                PhoneNumber = m.PhoneNumber,
                                Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                Code = m.Code,
                            })
                             .ToListAsync());
                }

                return Ok(clients);
            }
            else
            {
                return RedirectToAction(nameof(Index), new { refreshPage = true, isJsonReturn = true });

            }
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _context.Departments.ToListAsync();

            ViewData["departments"] = new SelectList(departments, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClientDTO model)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _context.Departments.ToListAsync();

                ViewData["departments"] = new SelectList(departments, "Id", "Name");

                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.ErrorMessage);
                    }
                }
                return View(ModelState);
            }

            var code = await _context.Clients.MaxAsync(m => m.Code) + 1;

            var client = new Client()
            {
                BaseUserId = model.BaseUserId,
                Code = code,
                ClientName = model.ClientName,
                Address = model.Address,
                DepartmentId = model.DepartmentId,
                PhoneNumber = model.PhoneNumber,
                CreatedAt = DateTime.Now,
                CreatedBy = _userManager.GetUserId(User),
                UpdatedAt = DateTime.Now,
                ClientStatus = Enums.StatusOfClient.NewRequest,
                CustomerNeeded = model.CustomerNeeded,
            };

            _context.Clients.Add(client);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> GetUsersByDepartmentId(string departmentId)
        {
            if (departmentId == null)
                return BadRequest();

            var users = (await _userManager.Users
                                .Where(m => m.DepartmentId == departmentId)
                                .ToListAsync());

            List<object> result = new List<object>();

            foreach (var user in users)
            {
                result.Add(
                    new
                    {
                        id = user.Id,
                        value = $"{user.FirstName} {user.LastName}"
                    });
            }

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> Details(string clientId)
        {

            var client = await _context.Clients
                                       .Include(m => m.Multimedias)
                                       .Include(m => m.Department)
                                       .Include(m => m.BaseUser)
                                       .SingleOrDefaultAsync(m => m.Id == clientId);

            if (client.ClientStatus == Enums.StatusOfClient.NewRequest)
            {
                var user = await _userManager.GetUserAsync(User);

                var isUserGeneralManager = await _userManager.IsInRoleAsync(user, Role.GeneralManager);

                if (!isUserGeneralManager)
                {
                    client.ClientStatus = Enums.StatusOfClient.UnderProgress;
                    
                    if (!client.SendFirstMessageToClient)
                    {
                        var result = await _whatsAppsSender.SendMessage(client.ClientName, client.PhoneNumber, WhatsAppTemplate.EmployeeSendOpenFileToClient);
                        if (result)
                        {
                            client.SendFirstMessageToClient = true;
                            ViewData["successSendMessage"] = "تم ارسال الرساله بنجاح";
                        }
                        else
                        {
                            ViewData["successSendMessage"] = "حدث خطأ أثناء ارسال الرساله";
                        }

                    }

                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }

            }
            
            var createdBy = await _userManager.FindByIdAsync(client.CreatedBy);
            var handledBy = await _userManager.FindByIdAsync(client.BaseUserId);


            var record = new DetailsClientDTO()
            {
                ClientId = client.Id,
                Address = client.Address,
                PhoneNumber = client.PhoneNumber,
                BillsFileOld = client.BillsFile,
                ClientName = client.ClientName,
                CustomerNeeded = client.CustomerNeeded,
                ClientCode = client.Code,
                HandledBy = $"{handledBy.FirstName} {handledBy.LastName}",
                CreatedBy = $"{createdBy.FirstName} {createdBy.LastName}",
                Notes = client.Notes,
                OldOtherFiles = new List<OldOtherFile>(),
            };

            foreach (var item in client.Multimedias)
            {
                record.OldOtherFiles.Add(new OldOtherFile
                {
                    Description = item.Description,
                    FileOld = item.Path,
                    OtherFileId = item.Id,
                });
            }


            return View(record);

        }

        [HttpPost]
        [Authorize(Roles = $"{Role.GeneralManager}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return BadRequest("حدث خطأ اثناء المسح");

            var client = await _context.Clients.FirstOrDefaultAsync(m => m.Id == id);

            if (client == null)
                return BadRequest("حدث خطأ اثناء المسح");

            try
            {
                _context.Remove(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("حدث خطأ اثناء المسح");
            }

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SavedFileAboutClient(DetailsClientDTO model, string clientId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var client = await _context.Clients.Include(m => m.Multimedias).SingleOrDefaultAsync(m => m.Id == model.ClientId);


            if (client == null)
                return BadRequest();

            if (!string.IsNullOrEmpty(model.Notes))
            {
                client.Notes = model.Notes;
            }


            if (model.BillsFileNew != null)
            {
                _fileManager.Delete(client.BillsFile);

                client.BillsFile = _fileManager.Upload(model.BillsFileNew);

                _context.Update(client);
                await _context.SaveChangesAsync();
            }

            if (model.NewOtherFiles != null)
            {
                foreach (var item in model.NewOtherFiles)
                {
                    if(item.NewFile != null  || !string.IsNullOrEmpty(item.Description))
                    {
                        var description = item.Description;
                        var file = _fileManager.Upload(item.NewFile);

                        client.Multimedias.Add(new Multimedia
                        {
                            ClientId = client.Id,
                            CreatedAt = DateTime.Now,
                            Description = description,
                            CreatedBy = _userManager.GetUserId(User),
                            UpdatedAt = DateTime.Now,
                            Path = file
                        });
                    }
                }

                _context.Update(client);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Details), new { clientId = model.ClientId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteOtherFile(string fileId)
        {
            var file = await _context.Multimedias.FirstOrDefaultAsync(m => m.Id == fileId);

            if (file != null)
            {
                _context.Remove(file);
                await _context.SaveChangesAsync();
            }
            else
                return BadRequest();

            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> TransformFileToFinancial(string clientId)
        {
            if (!ModelState.IsValid || string.IsNullOrEmpty(clientId))
                return BadRequest();

            var client = await _context.Clients.Include(m => m.Multimedias).SingleOrDefaultAsync(m => m.Id == clientId);

            if (client == null)
                return BadRequest();

            client.ClientStatus = Enums.StatusOfClient.FinancialTransformation;

            if (!client.SendSecondMessageToClient)
            {

                var result = await _whatsAppsSender.SendMessage(client.ClientName, client.PhoneNumber, WhatsAppTemplate.FinancialSendBillFileToClient);
                if (result)
                {
                    client.SendSecondMessageToClient = true;
                    ViewData["successSendMessage"] = "تم ارسال الرساله بنجاح";
                }
                else
                {
                    ViewData["successSendMessage"] = "حدث خطأ أثناء ارسال الرساله";
                }

            }


            _context.Update(client);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> FinisedFile(string clientId)
        {
            if (!ModelState.IsValid || string.IsNullOrEmpty(clientId))
                return BadRequest();

            var client = await _context.Clients.Include(m => m.Multimedias).SingleOrDefaultAsync(m => m.Id == clientId);

            if (client == null)
                return BadRequest();

            client.ClientStatus = Enums.StatusOfClient.Finished;

            _context.Update(client);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> GetAllClientHasFinancial()
        {
            var clients = await _context.Clients
                        .Where(m => m.ClientStatus == Enums.StatusOfClient.FinancialTransformation)
                        .Select(m => new ListClientDTO()
                        {
                            ClientName = m.ClientName,
                            Code = m.Code,
                            CreateAt = DateTime.Now,
                            Id = m.Id,
                            PhoneNumber = m.PhoneNumber,
                            Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name
                        }).ToListAsync();



            return View(clients);
        }

        [HttpGet]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            var result = await _fileManager.DownloadFile(fileName);

            var extension = Path.GetExtension(fileName);

            var descriptionFile = (await _context.Multimedias.SingleOrDefaultAsync(m => m.Path == fileName)).Description+extension;
            
            return File(result.Memory,result.ContentType,descriptionFile);
        }
    }
}
