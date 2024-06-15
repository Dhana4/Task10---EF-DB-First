using EmployeeConsoleEFDBFirst.services.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.Models;
using AutoMapper;

namespace EmployeeConsoleEFDBFirst.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeDataAccess;
    private readonly IMapper mapper;
    public EmployeeService(IEmployeeRepository employeeDataAccess, IMapper mapper)
    {
        this.employeeDataAccess = employeeDataAccess;
        this.mapper = mapper;
    }
    public void AddEmployee(EmployeeDTO employeeDTO)
    {
        Employee employee = mapper.Map<Employee>(employeeDTO);
        employeeDataAccess.AddEmployee(employee);
    }

    public void DeleteEmployee(int empId)
    {
        employeeDataAccess.DeleteEmployee(empId);
    }

    public List<EmployeeDTO> GetAllEmployees()
    {
        List<Employee> employees = employeeDataAccess.GetAllEmployees();
        List<EmployeeDTO> employeeDTOs = mapper.Map<List<EmployeeDTO>>(employees);
        return employeeDTOs;
    }

    public EmployeeDTO? GetEmployeeById(int empId)
    {
        Employee? employee = employeeDataAccess.GetEmployeeById(empId);
        return mapper.Map<EmployeeDTO?>(employee);
    }

    public List<EmployeeDTO> GetEmployeesByRoleId(int roleId)
    {
        List<Employee> employees = employeeDataAccess.GetEmployeesByRoleId(roleId);
        return mapper.Map<List<EmployeeDTO>>(employees);
    }
    public void UpdateEmployee(EmployeeDTO employeeDTO)
    {
        Employee employee = mapper.Map<Employee>(employeeDTO);
        employeeDataAccess.UpdateEmployee(employee);
    }
}
