using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.ApplicationLayer.DTOs;

public class DepartmentDTO
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}
