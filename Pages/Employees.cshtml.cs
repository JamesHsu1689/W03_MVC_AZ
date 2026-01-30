using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using W02_EF.Models.CompanyDB;

namespace W02_EF.Pages
{
    public class EmployeesModel : PageModel
    {
        private readonly CompanyContext _context;

        public EmployeesModel(CompanyContext context)
        {
            _context = context;
        }

        public List<Employee> Employees { get; set; } = new();

        public void OnGet()
        {
            Employees = _context.Employees.ToList();
        }
    }
}
