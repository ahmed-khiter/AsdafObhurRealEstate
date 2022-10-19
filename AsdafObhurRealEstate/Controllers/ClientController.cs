using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.Core;
using AsdafObhurRealEstate.DTO.ClientsDataTransferObject;
using AsdafObhurRealEstate.Enums;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using AsdafObhurRealEstate.Services.Clients;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

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
        public async Task<IActionResult> Index(bool isJson)
        {

            var clients = await _clientService.GetClients(User);

            var userId = _userManager.GetUserId(User);
            int totalCount = (await _context.Clients.CountAsync(m => m.BaseUserId == userId));
            ViewData["TotalCount"] = totalCount;

            if (isJson)
                return Ok(clients);

            return View(clients);
        }


        [HttpGet]
        public async Task<IActionResult> SearchClient(string userNameOrCode, bool heCreated)
        {
            int code = 0;
            var isNumber = int.TryParse(userNameOrCode, out code);
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var isUserIsFin = await _userManager.IsInRoleAsync(user, Role.Financial);

            List<ListClientDTO> clients = new List<ListClientDTO>();

            if (!string.IsNullOrEmpty(userNameOrCode))
            {



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
                            CreateAt = m.CreatedAt
                        })
                        .ToListAsync());
                }

             


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
                                 CreateAt = m.CreatedAt
                             })
                             .ToListAsync());
                }
                else if (isUserIsFin)
                {
                    clients.AddRange(await _context.Clients.Where(m => (m.Code == code || m.ClientName.Contains(userNameOrCode))
                    && m.ClientStatus == Enums.StatusOfClient.FinancialTransformation)
                            .Select(m => new ListClientDTO
                            {
                                Id = m.Id,
                                ClientName = m.ClientName,
                                PhoneNumber = m.PhoneNumber,
                                Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                Code = m.Code,
                                CreateAt = m.CreatedAt
                            })
                             .ToListAsync());
                }
                else
                {
                    clients.AddRange(await _context.Clients.Where(m => (m.Code == code || m.ClientName.Contains(userNameOrCode)) 
                    && m.BaseUserId == userId)
                            .Select(m => new ListClientDTO
                            {
                                Id = m.Id,
                                ClientName = m.ClientName,
                                PhoneNumber = m.PhoneNumber,
                                Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                Code = m.Code,
                                CreateAt = m.CreatedAt
                            })
                             .ToListAsync());
                }

                return Ok(clients);
            }
            else if(string.IsNullOrEmpty(userNameOrCode) && isUserIsFin)
            {

                clients.AddRange(await _context.Clients.Where(m => m.ClientStatus == Enums.StatusOfClient.FinancialTransformation)
                             .Select(m => new ListClientDTO
                             {
                                 Id = m.Id,
                                 ClientName = m.ClientName,
                                 PhoneNumber = m.PhoneNumber,
                                 Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                 Code = m.Code,
                                 CreateAt = m.CreatedAt
                             })
                             .ToListAsync());
                return Ok(clients);

            }
            else
            {
                return RedirectToAction(nameof(Index), new { isJson = true });

            }
        }

        [HttpGet]
        public async Task<IActionResult> SearchClientToKnowAssignOrCreate(string userNameOrCode, RelationEmployeeWithClient heCreated, string userId)
        {
            int code = 0;
            var isNumber = int.TryParse(userNameOrCode, out code);
            
            var user = await _userManager.FindByIdAsync(userId);
            var query = _context.Clients.Include(m => m.BaseUser).AsQueryable();
            List<ListClientDTO> clients = new List<ListClientDTO>();

            if (heCreated == RelationEmployeeWithClient.CreatedByHim)
            {
                query = query.Where(m => m.CreatedBy == userId);
            }
            else if(heCreated == RelationEmployeeWithClient.AssignedToHim)
            {
                query = query.Where(m => m.BaseUserId == userId);
            }
            else if(heCreated != RelationEmployeeWithClient.AssignToHimButNotCreatedByHim)
            {
                query = query.Where(m => m.BaseUserId == userId && m.CreatedBy != userId);
            }
            else
            {
                query = query.Where(m => m.BaseUserId == userId && m.ClientStatus == StatusOfClient.Finished);

            }

            if (string.IsNullOrEmpty(userNameOrCode))
            {
                var users = await query.Where(m => m.Code == code || m.ClientName.Contains(userNameOrCode))
                            .Select(m => new ListClientDTO
                            {
                                Id = m.Id,
                                ClientName = m.ClientName,
                                PhoneNumber = m.PhoneNumber,
                                Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                Code = m.Code,
                                CreateAt = m.CreatedAt
                            }).ToListAsync();

                clients.AddRange(users);
            }
            else
            {
                var users = await query.Select(m => new ListClientDTO
                                {
                                    Id = m.Id,
                                    ClientName = m.ClientName,
                                    PhoneNumber = m.PhoneNumber,
                                    Status = m.ClientStatus.GetAttribute<DisplayAttribute>().Name,
                                    Code = m.Code,
                                    CreateAt = m.CreatedAt
                                }).ToListAsync();

                clients.AddRange(users);
            }
           
            return Ok(clients);
        }


        public async Task<IActionResult> Create()
        {
            var departments = await _context.Departments.ToListAsync();

            ViewData["departments"] = new SelectList(departments, "Id", "Name");

            var countryPhone = ListOfPhoneNumber();

            ViewData["listPhone"] = new SelectList(countryPhone, "nameAr", "code");


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClientDTO model)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _context.Departments.ToListAsync();

                ViewData["departments"] = new SelectList(departments, "Id", "Name");

                var countryPhone = ListOfPhoneNumber();

                ViewData["listPhone"] = new SelectList(countryPhone, "Id", "code");

                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.ErrorMessage);
                    }
                }
                return View(ModelState);
            }

            var maxCode = await _context.Clients.MaxAsync(m => (int?)m.Code)?? 0;
            var code = maxCode + 1;

            var resultString = Regex.Match(model.CodePhoneNumber, @"\d+").Value;
            int codeNumber = 966; 
            
            int.TryParse(resultString,out codeNumber);

            model.PhoneNumber = codeNumber + model.PhoneNumber;
            
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
                CodeNumber = codeNumber,
                ClientStatus = Enums.StatusOfClient.NewRequest,
                CustomerNeeded = model.CustomerNeeded,
                NotesBeforeWhileCreating = model.NotesBeforeWhileCreating
            };

            _context.Clients.Add(client);

            await _context.SaveChangesAsync();

            if (model.NewOtherFiles.Count > 0 || model.NewOtherFiles != null )
            {
                var items = new List<Multimedia>();

                foreach (var item in model.NewOtherFiles)
                {
                    if (item.NewFile != null && !string.IsNullOrEmpty(item.Description))
                    {
                        var description = item.Description;
                        var file = _fileManager.Upload(item.NewFile);

                        items.Add(new Multimedia
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
                _context.Multimedias.AddRange(items);

                await _context.SaveChangesAsync();

            }

           

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
                CreatedAt = client.CreatedAt.ToString("dd/MM/yyyy"),
                HandledBy = $"{handledBy.FirstName} {handledBy.LastName}",
                CreatedBy = $"{createdBy.FirstName} {createdBy.LastName}",
                Notes = client.Notes,
                Status = client.ClientStatus.GetAttribute<DisplayAttribute>().Name,
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
                    if (item.NewFile != null && !string.IsNullOrEmpty(item.Description))
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
                    ViewData["errorSendMessage"] = "حدث خطأ أثناء ارسال الرساله الي العميل";
                }

            }


            _context.Update(client);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> FinisedFile(string clientId)
        {
            if (!ModelState.IsValid || string.IsNullOrEmpty(clientId))
                return BadRequest();

            var client = await _context.Clients.Include(m => m.Multimedias).SingleOrDefaultAsync(m => m.Id == clientId);

            if (client == null)
                return BadRequest();

            if (client.ClientStatus == Enums.StatusOfClient.UnderProgress)
            {
                return BadRequest("يجب تحويل الملف للمالية أولا");
            }

            client.ClientStatus = Enums.StatusOfClient.Finished;

            try
            {
                _context.Update(client);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                return BadRequest("حدث خطأ أثناء الإغلاق الملف حاول مرة اخرى");
            }

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> GetAllClientHasFinancial()
        {
            int totalCount = await _context.Clients.CountAsync(m => m.ClientStatus == Enums.StatusOfClient.FinancialTransformation);
            ViewData["TotalCount"] =totalCount ;
            var clients = await _context.Clients
                        .Where(m => m.ClientStatus == Enums.StatusOfClient.FinancialTransformation)
                        .OrderByDescending(m => m.Code)
                        .Take(10)
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

            var descriptionFile = (await _context.Multimedias.SingleOrDefaultAsync(m => m.Path == fileName)).Description + extension;

            return File(result.Memory, result.ContentType, descriptionFile);
        }

        [HttpGet]
        public async Task<IActionResult> DownloadBill(string clientId)
        {
            var client = (await _context.Clients.SingleOrDefaultAsync(m => m.Id == clientId));
            var result = await _fileManager.DownloadFile(client.BillsFile);

            var extension = Path.GetExtension(client.BillsFile);

            var fileDescription = $"فاتورة العميل {client.ClientName}" + extension;
            return File(result.Memory, result.ContentType, fileDescription);
        }

        [HttpPost]
        public async Task<IActionResult> PaginationClient(QueryParameters param, [FromQuery] string userId)
        {
            // Get all clients as collection of queryable
            var query = _context.Clients.OrderByDescending(m => m.Code).AsQueryable();
            query = query.Where(m => m.BaseUserId == userId);
            var count = await query.CountAsync();
            var items = await query.Skip((param.Page-1) * param.Limit).Take(param.Limit).ToListAsync();
            var resultPageList = new PagedList<Client>(items, count, param.Page, param.Limit);

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

        [HttpPost]
        public async Task<IActionResult> PaginationClient(QueryParameters param, [FromQuery] string userId, [FromQuery] bool isCreated)
        {
            // Get all clients as collection of queryable
            var query = _context.Clients.OrderByDescending(m => m.Code).AsQueryable();
            
            if(isCreated)
                query = query.Where(m => m.CreatedBy == userId);
            else
                query = query.Where(m => m.BaseUserId == userId);

            var count = await query.CountAsync();
            var items = await query.Skip((param.Page - 1) * param.Limit).Take(param.Limit).ToListAsync();
            var resultPageList = new PagedList<Client>(items, count, param.Page, param.Limit);

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

        [HttpPost]
        public async Task<IActionResult> PaginationClientForFin(QueryParameters param)
        {
            // Get all clients as collection of queryable
            var query = _context.Clients.OrderByDescending(m => m.Code).AsQueryable();
            query = query.Where(m => m.ClientStatus == Enums.StatusOfClient.FinancialTransformation);
            var count = await query.CountAsync();
            var items = await query.Skip((param.Page - 1) * param.Limit).Take(param.Limit).ToListAsync();
            var resultPageList = new PagedList<Client>(items, count, param.Page, param.Limit);

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


        [HttpPost]
        public async Task<IActionResult> PaginationClientForAdmin(QueryParameters param)
        {
            // Get all clients as collection of queryable
            var query = _context.Clients.OrderByDescending(m => m.Code).AsQueryable();
            
            var count = await query.CountAsync();
            var items = await query.Skip((param.Page - 1) * param.Limit).Take(param.Limit).ToListAsync();
            var resultPageList = new PagedList<Client>(items, count, param.Page, param.Limit);

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
        public async Task<IActionResult> ClientsWhoAssignedToAnotherEmp(bool isJson)
        {

            var clients = await _clientService.GetClientsWhoAssigned(User);

            var userId = _userManager.GetUserId(User);
            int totalCount = (await _context.Clients.CountAsync(m => m.CreatedBy == userId));
            ViewData["TotalCount"] = totalCount;

            if (isJson)
                return Ok(clients);

            return View(clients);
        }

        [HttpGet]
        public async Task<IActionResult> ClientsCreatedOrAssignedTo(int relationWithClient, string id)
        {
            var output = new List<Client>();
            int totalCount =0 ;

            if (relationWithClient ==(int) RelationEmployeeWithClient.CreatedByHim)
            {
                totalCount = await _context.Clients.CountAsync(m => m.CreatedBy == id);

                output.AddRange(await _context.Clients.OrderBy(m => m.Code).Take(10).Include(m => m.BaseUser)
                        .Where(m => m.CreatedBy == id).ToListAsync());
            }
            else if(relationWithClient == (int) RelationEmployeeWithClient.AssignedToHim)
            {
                totalCount = await _context.Clients.CountAsync(m => m.BaseUserId == id);

                output.AddRange(await _context.Clients.OrderBy(m => m.Code).Take(10).Include(m => m.BaseUser)
                    .Where(m => m.BaseUserId == id).ToListAsync());
            }
            else if(relationWithClient == (int) RelationEmployeeWithClient.AssignToHimButNotCreatedByHim)
            {
                totalCount = await _context.Clients.CountAsync(m => m.BaseUserId == id && m.CreatedBy != id );

                output.AddRange(await _context.Clients.OrderBy(m => m.Code).Take(10).Include(m => m.BaseUser)
                    .Where(m => m.BaseUserId == id && m.CreatedBy != id).ToListAsync());
            }
            else
            {
                totalCount = await _context.Clients.CountAsync(m => m.BaseUserId == id && m.ClientStatus == StatusOfClient.Finished);

                output.AddRange(await _context.Clients.OrderBy(m => m.Code).Take(10).Include(m => m.BaseUser)
                    .Where(m => m.BaseUserId == id && m.ClientStatus== StatusOfClient.Finished).ToListAsync());
            }

            ViewData["baseUserId"] = id;
            ViewData["isCreated"] = relationWithClient;
            ViewData["TotalCount"] = totalCount;

            return View(output);
        
        }

        private List<CountryPhoneNumber> ListOfPhoneNumber()
        {
            var countryPhone = new List<CountryPhoneNumber>();
            using (StreamReader r = new StreamReader("LanguagePhone.json"))
            {
                string json = r.ReadToEnd();
                countryPhone.AddRange(JsonConvert.DeserializeObject<List<CountryPhoneNumber>>(json));
            }

            return countryPhone;
        }
    }

}
