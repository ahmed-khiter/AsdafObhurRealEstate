using AsdafObhurRealEstate.Infrastructure;
using AsdafObhurRealEstate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsdafObhurRealEstate.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AsdafObhurContext _context;

        public DepartmentController(AsdafObhurContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index() =>
            View(await _context.Departments.ToListAsync());

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "الرجاء كتابه اسم القسم");
                return View(nameof(Create));
            }
            model.CreatedBy = User.FindFirst("fullName").Value;
            model.CreatedAt = DateTime.Now;
            model.UpdatedAt = DateTime.Now;

            await _context.Departments.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var department = await _context.Departments
                                    .Include(m => m.Users)
                                    .FirstOrDefaultAsync(m => m.Id == id);

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
            //modifyDepartment.ModifiedBy = User.Identity.Name;
            modifyDepartment.UpdatedAt = DateTime.Now;

            return RedirectToAction(nameof(Index));
        }

    }
}
