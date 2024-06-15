﻿using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.Data;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly EmployeeConsoleEfdbfirstContext dbContext;

    public EmployeeRepository(EmployeeConsoleEfdbfirstContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void AddEmployee(Employee employee)
    {
        dbContext.Employees.Add(employee);
        dbContext.SaveChanges();
    }

    public void DeleteEmployee(int empId)
    {
        var employeeToDelete = dbContext.Employees.Find(empId);
        if (employeeToDelete != null)
        {
            dbContext.Employees.Remove(employeeToDelete);
            dbContext.SaveChanges();
        }
    }

    public List<Employee> GetAllEmployees()
    {
        return dbContext.Employees.ToList();
    }

    public Employee? GetEmployeeById(int empId)
    {
        return dbContext.Employees.Find(empId);
    }

    public List<Employee> GetEmployeesByRoleId(int roleId)
    {
        return dbContext.Employees.Where(e => e.RoleId == roleId).ToList();
    }

    public void UpdateEmployee(Employee employee)
    {
        var existingEmployee = dbContext.Employees.Find(employee.EmpId);
        if (existingEmployee != null)
        {
            dbContext.Entry(existingEmployee).State = EntityState.Detached;
            dbContext.Employees.Update(employee);
            dbContext.SaveChanges();
        }
    }
}
