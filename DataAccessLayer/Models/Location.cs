using System;
using System.Collections.Generic;

namespace EmployeeConsoleEFDBFirst.Data.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
