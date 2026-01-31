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
    public class IndexModel : PageModel
    {
        private readonly W02_EF.Models.CompanyDB.CompanyContext _context;

        public IndexModel(W02_EF.Models.CompanyDB.CompanyContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Department = await _context.Departments.ToListAsync();
        }
    }
}
