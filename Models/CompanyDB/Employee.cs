using System;
using System.Collections.Generic;

namespace W02_EF.Models.CompanyDB;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
