using EmployeeConsoleEFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.services.Interfaces;

public interface IRoleService
{
    List<RoleDTO> GetAllRoles();
    void AddRole(RoleDTO role);
    RoleDTO GetRoleById(int roleId);
    void EditRole(RoleDTO updatedRole);
    bool IdRoleIdValid(int roleId);
}
