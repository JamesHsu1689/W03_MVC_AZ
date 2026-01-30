using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using W02_EF.Models.CompanyDB;

namespace W02_EF.Pages;

public class DepartmentsModel : PageModel
{
    private readonly CompanyContext _context;

    public DepartmentsModel(CompanyContext context)
    {
        _context = context;
    }

    public List<Department> Departments { get; set; } = new();

    public void OnGet()
    {
        Departments = _context.Departments.ToList();
    }
}
