using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AsdafObhurContext _context;
        private readonly UserManager<BaseUser> _userManager;

        public DepartmentController(AsdafObhurContext context, UserManager<BaseUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index() =>
            View(await _context.Departments.ToListAsync());

        public IActionResult Create() => View();


        [HttpPost]
        public async Task<IActionResult> Create(Department model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "الرجاء كتابه اسم القسم");
                return View(nameof(Create));
            }

            var department = new Department
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = _userManager.GetUserId(User),
                Name = model.Name,
            };
            
            await _context.Departments.AddAsync(department);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var department = await _context.Departments.Include(m => m.Users).FirstOrDefaultAsync(m => m.Id == id);

            return View(department);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return View(await _context.Departments.FirstOrDefaultAsync(m => m.Id == id));
        }


        [HttpPost]
        public async Task<IActionResult> Edit(Department department, string id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Edit),new {id = id });
            }

            var modifyDepartment = await _context.Departments.FirstOrDefaultAsync(m => m.Id == id);
            modifyDepartment.Name = department.Name;
            modifyDepartment.ModifiedBy = _userManager.GetUserId(User);
            modifyDepartment.UpdatedAt = DateTime.Now;

            _context.Update(modifyDepartment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(string departmentId)
        {
            try
            {
                var model = await _context.Departments.FirstOrDefaultAsync(m => m.Id == departmentId);
            
                if (model == null)
                    return BadRequest();

                _context.Remove(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("يجب مسح الموظفين المرتبطين بهذا القسم أولا");
            }

            return Ok();
        }

    }
}
