using Microsoft.Extensions.DependencyInjection;
using EmployeeConsoleEFDBFirst.services.Interfaces;
using EmployeeConsoleEFDBFirst.Services;
using EmployeeConsoleEFDBFirst.Data.Interfaces;
using EmployeeConsoleEFDBFirst.Data;
using EmployeeConsoleEFDBFirst.Data.Models;
namespace EmployeeConsoleEFDBFirst.Presentation;
class Program
{
    private static IServiceProvider serviceProvider;
    static void Main(string[] args)
    {
        RegisterServices();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Employee Management");
            Console.WriteLine("2. Role Management");
            Console.WriteLine("3. View all Employees in a particular Role");
            Console.WriteLine("4. Exit");
            int choice = default;
            string choiceString = string.Empty;
            bool choiceEntered = false;
            while (!choiceEntered)
            {
                choiceString = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(choiceString, out choice))
                {
                    choiceEntered = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Enter again");
                }
            }
            switch (choice)
            {
                case 1:
                    EmployeeManagementMenu();
                    break;
                case 2:
                    RoleManagementMenu();
                    break;
                case 3:
                    var employeeHelper = serviceProvider.GetService<IEmployeeHelper>();
                    employeeHelper.ViewAllEmpInRole();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Enter again");
                    break;
            }
        }
        DisposeServices();
    }
    static void EmployeeManagementMenu()
    {
        bool goBack = false;
        while (!goBack)
        {
            Console.WriteLine("Employee Management Menu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All");
            Console.WriteLine("3. Display One");
            Console.WriteLine("4. Edit Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Go Back");
            int choice = default;
            string choiceString = string.Empty;
            bool choiceEntered = false;
            var employeeService = serviceProvider.GetService<IEmployeeHelper>();
            while (!choiceEntered)
            {
                choiceString = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(choiceString, out choice))
                {
                    choiceEntered = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Enter again");
                }
            }
            switch (choice)
            {
                case 1:
                    employeeService.AddEmployee();
                    break;
                case 2:
                    employeeService.DisplayAllEmployees();
                    break;
                case 3:
                    employeeService.DisplayOneEmployee();
                    break;
                case 4:
                    employeeService.EditEmployee();
                    break;
                case 5:
                    employeeService.DeleteEmployee();
                    break;
                case 6:
                    goBack = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Enter again");
                    break;
            }
        }
    }
    static void RoleManagementMenu()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Role Management Menu");
            Console.WriteLine("1. Add Role");
            Console.WriteLine("2. Edit Role");
            Console.WriteLine("3. Back to Main Menu");
            int choice = default;
            bool choiceEntered = false;
            var roleService = serviceProvider.GetService<IRoleHelper>();
            while (!choiceEntered)
            {
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    choiceEntered = true;
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Enter again");
                }
            }
            switch (choice)
            {
                case 1:
                    roleService.AddRole();
                    break;
                case 2:
                    roleService.EditRole();
                    break;
                case 3:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Enter again");
                    break;
            }
        }
    }
    public static void RegisterServices()
    {
        var services = new ServiceCollection();
        services.AddTransient<IEmployeeService, EmployeeService>();
        services.AddTransient<IRoleService, RoleService>();
        services.AddTransient<IDepartmentService, Departmentservice>();
        services.AddTransient<ILocationService, LocationService>();
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        services.AddTransient<IRoleRepository, RoleRepository>();
        services.AddTransient<IDepartmentRepository, DepartmentRepository>();
        services.AddTransient<ILocationRepository, LocationRepository>();
        services.AddTransient<IEmployeeHelper, EmployeeHelper>();
        services.AddTransient<IRoleHelper, RoleHelper>();
        services.AddTransient<ILocationHelper, LocationHelper>();
        services.AddTransient<IDepartmentHelper, DepartmentHelper>();
        services.AddTransient<EmployeeConsoleEfdbfirstContext>();
        services.AddAutoMapper(typeof(MappingProfile).Assembly);
        serviceProvider = services.BuildServiceProvider();
    }
    public static void DisposeServices()
    {
        if (serviceProvider == null)
        {
            return;
        }
        if (serviceProvider is IDisposable)
        {
            ((IDisposable)serviceProvider).Dispose();
        }
    }
}