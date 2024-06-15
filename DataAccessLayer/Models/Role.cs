using System;
using System.Collections.Generic;

namespace EmployeeConsoleEFDBFirst.Data.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string? Description { get; set; }

    public int LocationId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Location Location { get; set; } = null!;
}
