using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.Models;

namespace EmployeeConsoleEFDBFirst.services.Interfaces;

public interface IEmployeeService
{
    void AddEmployee(EmployeeDTO employee);
    List<EmployeeDTO> GetAllEmployees();
    EmployeeDTO? GetEmployeeById(int empId);
    void UpdateEmployee(EmployeeDTO employee);
    void DeleteEmployee(int empId);
    List<EmployeeDTO> GetEmployeesByRoleId(int roleId);
}
