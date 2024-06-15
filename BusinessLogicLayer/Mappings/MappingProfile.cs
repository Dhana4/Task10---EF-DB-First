using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.Models;
using EmployeeConsoleEFDBFirst.Data.Models;
namespace EmployeeConsoleEFDBFirst.Services;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<EmployeeDTO, Employee>();
        CreateMap<Employee, EmployeeDTO>();
        CreateMap<RoleDTO, Role>();
        CreateMap<Role, RoleDTO>();
        CreateMap<LocationDTO, Location>();
        CreateMap<Location, LocationDTO>();
        CreateMap<DepartmentDTO, Department>();
        CreateMap<Department, DepartmentDTO>();
    }
}
