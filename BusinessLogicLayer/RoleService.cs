using EmployeeConsoleEFDBFirst.services.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Models;
using EmployeeConsoleEFDBFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace EmployeeConsoleEFDBFirst.Services;

public class RoleService : IRoleService
{
    private readonly IRoleRepository roleRepository;
    private readonly IMapper mapper;

    public RoleService(IRoleRepository roleRepository, IMapper mapper)
    {
        this.roleRepository = roleRepository;
        this.mapper = mapper;
    }
    public void AddRole(RoleDTO roleDTO)
    {
        Role role = mapper.Map<Role>(roleDTO);
        roleRepository.AddRole(role);
    }

    public void EditRole(RoleDTO updatedRoleDTO)
    {
        Role role = mapper.Map<Role>(updatedRoleDTO);
        roleRepository.EditRole(role);
    }

    public List<RoleDTO> GetAllRoles()
    {
        List<Role> roles = roleRepository.GetAllRoles();
        return mapper.Map<List<RoleDTO>>(roles);
    }

    public RoleDTO GetRoleById(int roleId)
    {
        Role role = roleRepository.GetRoleById(roleId);
        return mapper.Map<RoleDTO>(role);
    }
    public bool IdRoleIdValid(int roleId)
    {
        return roleRepository.IsRoleIdValid(roleId);
    }
}
