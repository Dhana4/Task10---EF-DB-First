using EmployeeConsoleEFDBFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.Data.Interfaces;

public interface ILocationRepository
{
    List<Location> GetAllLocations();
    void AddLocation(Location location);
    Location GetLocationById(int locationId);
    void EditLocation(Location updatedLocation);
    bool IsLocationIdValid(int locationId);
}
