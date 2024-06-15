using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.Services;
using EmployeeConsoleEFDBFirst.services.Interfaces;
//using EmployeeConsoleEFDBFirst.Data.Models;
using EmployeeConsoleEFDBFirst.Models;
namespace EmployeeConsoleEFDBFirst.Presentation;

public class DepartmentHelper : IDepartmentHelper
{
    public readonly IDepartmentService departmentManager;
    public DepartmentHelper(IDepartmentService departmentManager)
    {
        this.departmentManager = departmentManager;
    }
    public bool DisplayAvailableDepartments()
    {
        List<DepartmentDTO> departments = departmentManager.GetAllDepartments();
        if (departments.Count == 0)
        {
            Console.WriteLine("No Roles Exist. Please Add a role first");
            return false;
        }
        foreach (DepartmentDTO department in departments)
        {
            Console.WriteLine($"Department Id: {department.DepartmentId}\nDepartment Name: {department.DepartmentName}");
        }
        return true;
    }
}
