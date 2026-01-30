using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using W02_EF.Models.CompanyDB;

namespace W02_EF.Pages
{
    public class EmployeesByDepartmentModel : PageModel
    {
        private readonly CompanyContext _context;

        public EmployeesByDepartmentModel(CompanyContext context)
        {
            _context = context;
        }

        public List<Department> Departments { get; set; } = new();

        public void OnGet()
        {
            Departments = _context.Departments
                .Include(d => d.Employees)
                .ToList();
        }
    }
}
