using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.Data;

public class DepartmentRepository : IDepartmentRepository
{
    private readonly EmployeeConsoleEfdbfirstContext dbContext;

    public DepartmentRepository(EmployeeConsoleEfdbfirstContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void AddDepartment(Department department)
    {
        dbContext.Departments.Add(department);
        dbContext.SaveChanges();
    }
    public void Editdepartment(Department updateddepartment)
    {
        var existingdepartment = dbContext.Departments.Find(updateddepartment.DepartmentId);
        if (existingdepartment != null)
        {
            dbContext.Entry(existingdepartment).State = EntityState.Detached;
            dbContext.Departments.Update(updateddepartment);
            dbContext.SaveChanges();
        }
    }

    public List<Department> GetAllDepartments()
    {
        return dbContext.Departments.ToList();
    }

    public Department GetDepartmentById(int departmentId)
    {
        return dbContext.Departments.Find(departmentId);
    }
    public bool IsDepartmentIdValid(int departmentId)
    {
        bool isDepartmentIdValid = false;
        List<Department> departments = GetAllDepartments();
        foreach (Department department in departments)
        {
            if (department.DepartmentId == departmentId)
            {
                isDepartmentIdValid = true;
            }
        }
        return isDepartmentIdValid;
    }
}
