using System;
using System.Collections.Generic;

namespace EmployeeConsoleEFDBFirst.Data.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
