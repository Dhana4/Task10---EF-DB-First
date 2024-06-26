﻿using EmployeeConsoleEFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleEFDBFirst.services.Interfaces;

public interface ILocationService
{
    List<LocationDTO> GetAllLocations();
    void AddLocation(LocationDTO location);
    LocationDTO GetLocationById(int locationId);
    void EditLocation(LocationDTO updatedLocation);
    bool IsLocationIdValid(int locationId);
}
