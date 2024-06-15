using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeConsoleEFDBFirst.services.Interfaces;
//using EmployeeConsoleEFDBFirst.Data.Models;
using EmployeeConsoleEFDBFirst.Models;
namespace EmployeeConsoleEFDBFirst.Presentation;

public class LocationHelper : ILocationHelper
{
    private readonly ILocationService locationManager;
    public LocationHelper(ILocationService locationManager)
    {
        this.locationManager = locationManager;
    }
    public bool DisplayAvailableLocations()
    {
        List<LocationDTO> locations = locationManager.GetAllLocations();
        if (locations.Count == 0)
        {
            Console.WriteLine("No Roles Exist. Please Add a role first");
            return false;
        }
        foreach (LocationDTO location in locations)
        {
            Console.WriteLine($"Location Id: {location.LocationId}\nLocation Name: {location.LocationName}");
        }
        return true;
    }
}
