using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using W02_EF.Models.CompanyDB;

namespace W02_EF.Pages
{
    public class EmployeeCountByDepartmentModel : PageModel
    {
        private readonly CompanyContext _context;

        public EmployeeCountByDepartmentModel(CompanyContext context)
        {
            _context = context;
        }

        // Simple view model row (course-friendly)
        public class DeptCountRow
        {
            public string DepartmentName { get; set; } = "";
            public int EmployeeCount { get; set; }
        }

        public List<DeptCountRow> Rows { get; set; } = new();

        public void OnGet()
        {
            var qry =
                from e in _context.Employees
                join d in _context.Departments on e.DepartmentId equals d.DepartmentId
                group e by d.DepartmentName into g
                orderby g.Key
                select new DeptCountRow
                {
                    DepartmentName = g.Key,
                    EmployeeCount = g.Count()
                };

            Rows = qry.ToList();
        }
    }
}
