using AsdafObhurRealEstate.Constants;
using AsdafObhurRealEstate.DTO.ClientsDataTransferObject;
using AsdafObhurRealEstate.Helpers;
using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Controllers
{
    public class ClientController : Controller
    {
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;
        private readonly FileManager _fileManager;
        public ClientController(AsdafObhurContext context, UserManager<BaseUser> userManager, FileManager fileManager)
        {
            _context = context;
            _userManager = userManager;
            _fileManager = fileManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);

            var user = await _userManager.FindByIdAsync(userId);
            
            if (await _userManager.IsInRoleAsync(user,Role.GeneralManager))
            {
                return View(await _context.Clients.ToListAsync());
            }
            

            var clients = await _context.Clients.Where(m => m.BaseUserId == userId).ToListAsync();
            
            return View(clients);
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _context.Departments.ToListAsync();

            ViewData["departments"] = new SelectList( departments, "Id", "Name" );

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

            var code = await _context.Clients.CountAsync() + 1;

            var client = new Client()
            {
                BaseUserId = model.BaseUserId,
                Code = code,
                ClientName = model.ClientName,
                DepartmentId = model.DepartmentId,
                PhoneNumber = model.PhoneNumber,
                CreatedAt = DateTime.Now,
                CreatedBy = _userManager.GetUserId(User),
                UpdatedAt = DateTime.Now,
                ClientStatus = Enums.StatusOfClient.NewRequest,
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

            var users = ( await _userManager.Users
                                .Where(m => m.DepartmentId == departmentId)
                                .ToListAsync());

            List<object> result = new List<object>();

            foreach (var user in users)
            {
                result.Add( 
                    new
                    {
                        id=user.Id,
                        value = $"{user.FirstName} {user.LastName}"
                    });
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> UploadInvoice(UploadInvoiceDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var client = await _context.Clients.SingleOrDefaultAsync(m => m.Id == model.ClientId);
            
            if (client == null)
                return BadRequest();

            client.BillsFile = _fileManager.Upload(model.File);


            _context.Update(client);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> uploadMultipleFile(MultipleUploadFile model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var client = await _context.Clients.Include(m => m.Multimedias).SingleOrDefaultAsync(m => m.Id == model.ClientId);

            if (client == null)
                return BadRequest();

            foreach (var item in model.Medias)
            {
                var description = item.Description;
                var file = _fileManager.Upload(item.File);

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

            _context.Update(client);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Details(string clientId)
        {
            
            var client = await _context.Clients
                                       .Include(m => m.Multimedias)
                                       .Include(m => m.Department)
                                       .Include(m => m.BaseUser)
                                       .SingleOrDefaultAsync(m => m.Id == clientId);

            if(client.ClientStatus == Enums.StatusOfClient.NewRequest)
            {
                var user = await _userManager.GetUserAsync(User);

                var isUserGeneralManager = await _userManager.IsInRoleAsync(user, Role.GeneralManager);

                if (!isUserGeneralManager)
                {
                    client.ClientStatus = Enums.StatusOfClient.UnderProgress;

                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }

            }

            var record = new DetailsClientDTO()
            {
                ClientId = client.Id,
                PhoneNumber = client.PhoneNumber,
                BillsFileOld = client.BillsFile,
                ClientName = client.ClientName,
                Notes   = client.Notes,
                OldOtherFiles = new List<OldOtherFile>(),
                OtherFileNews = new List<OtherFileNew>()
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

        [HttpGet]
        public async Task<IActionResult> AddNewBill(IFormFile billFile, string clientId)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(m => m.Id == clientId);

            if (billFile != null)
            {
                client.BillsFile = _fileManager.Upload(billFile);

                _context.Update(client);
                await _context.SaveChangesAsync();
            }
            else
                return BadRequest();

            return Ok();
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

        [HttpGet]
        public async Task<IActionResult> AddedOtherFile(List<OtherFileNew> model, string clientId)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(m => m.Id == clientId);

            if (model == null)
                return BadRequest();

            var userId = _userManager.GetUserId(User);

            foreach (var otherFileNew in model)
            {
                _context.Multimedias.Add(new Multimedia
                {
                    ClientId = clientId,
                    CreatedAt = DateTime.Now,
                    CreatedBy = userId,
                    Description = otherFileNew.Description,
                    Path = _fileManager.Upload(otherFileNew.FileNew),
                });
            }

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
