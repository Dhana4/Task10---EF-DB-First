using System;
using System.Collections.Generic;

namespace EmployeeConsoleEFDBFirst.Data.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Email { get; set; } = null!;

    public string? Mobile { get; set; }

    public DateTime JoiningDate { get; set; }

    public int RoleId { get; set; }

    public string? Manager { get; set; }

    public string? Project { get; set; }

    public virtual Role Role { get; set; } = null!;
}
