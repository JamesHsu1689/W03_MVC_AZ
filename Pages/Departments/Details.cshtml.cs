using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W02_EF.Models.CompanyDB;

namespace W02_EF.Pages_Departments
{
    public class DetailsModel : PageModel
    {
        private readonly W02_EF.Models.CompanyDB.CompanyContext _context;

        public DetailsModel(W02_EF.Models.CompanyDB.CompanyContext context)
        {
            _context = context;
        }

        public Department Department { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FirstOrDefaultAsync(m => m.DepartmentId == id);

            if (department is not null)
            {
                Department = department;

                return Page();
            }

            return NotFound();
        }
    }
}
