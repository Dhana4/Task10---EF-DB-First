using EmployeeConsoleEFDBFirst.services.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data.Models;
using EmployeeConsoleEFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace EmployeeConsoleEFDBFirst.Services;

public class Departmentservice : IDepartmentService
{
    private readonly IDepartmentRepository departmentRepository;
    private readonly IMapper mapper;

    public Departmentservice(IDepartmentRepository departmentRepository, IMapper mapper)
    {
        this.departmentRepository = departmentRepository;
        this.mapper = mapper;
    }
    public void AddDepartment(DepartmentDTO departmentDTO)
    {
        Department department = mapper.Map<Department>(departmentDTO);
        departmentRepository.AddDepartment(department);
    }

    public void EditDepartment(DepartmentDTO updatedDepartmentDTO)
    {
        Department department = mapper.Map<Department>(updatedDepartmentDTO);
        departmentRepository.Editdepartment(department);
    }

    public List<DepartmentDTO> GetAllDepartments()
    {
        List<Department> departments = departmentRepository.GetAllDepartments();
        return mapper.Map<List<DepartmentDTO>>(departments);
    }

    public DepartmentDTO GetDepartmentById(int departmentId)
    {
        Department department = departmentRepository.GetDepartmentById(departmentId);
        return mapper.Map<DepartmentDTO>(department);
    }
    public bool IsDepartmentIdValid(int departmentId)
    {
        return departmentRepository.IsDepartmentIdValid(departmentId);
    }
}
