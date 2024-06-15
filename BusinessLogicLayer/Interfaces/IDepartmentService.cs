using EmployeeConsoleEFDBFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.Models;

namespace EmployeeConsoleEFDBFirst.services.Interfaces;

public interface IDepartmentService
{
    List<DepartmentDTO> GetAllDepartments();
    void AddDepartment(DepartmentDTO department);
    DepartmentDTO GetDepartmentById(int departmentId);
    void EditDepartment(DepartmentDTO updatedDepartment);
    bool IsDepartmentIdValid(int departmentId);
}
