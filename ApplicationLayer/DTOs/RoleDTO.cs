using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.ApplicationLayer.DTOs;

public class RoleDTO
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public string? Description { get; set; }

    public int LocationId { get; set; }
}
