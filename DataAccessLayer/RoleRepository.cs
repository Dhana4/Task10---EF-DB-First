using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.Data;
public class RoleRepository : IRoleRepository
{
    private readonly EmployeeConsoleEfdbfirstContext dbContext;

    public RoleRepository(EmployeeConsoleEfdbfirstContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public void AddRole(Role role)
    {
        dbContext.Roles.Add(role);
        dbContext.SaveChanges();
    }

    public void EditRole(Role updatedRole)
    {
        Role existingRole = dbContext.Roles.Find(updatedRole.RoleId);
        if (existingRole != null)
        {
            dbContext.Entry(existingRole).State = EntityState.Detached;
            dbContext.Roles.Update(updatedRole);
            dbContext.SaveChanges();
        }
    }

    public List<Role> GetAllRoles()
    {
        return dbContext.Roles.ToList();
    }

    public Role GetRoleById(int roleId)
    {
        return dbContext.Roles.Find(roleId);
    }
    public bool IsRoleIdValid(int roleId)
    {
        bool isRoleValid = false;
        var roles = GetAllRoles();
        foreach (var role in roles)
        {
            if (role.RoleId == roleId)
            {
                isRoleValid = true;
                break;
            }
        }
        return isRoleValid;
    }
}
