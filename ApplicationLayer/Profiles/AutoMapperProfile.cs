using AutoMapper;
using EmployeeConsoleEFDBFirst.ApplicationLayer.DTOs;
using EmployeeConsoleEFDBFirst.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DepartmentDTO, Department>();
        }
    }
}
