using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStatus.Core.Domain.Vehicles
{
    public class VehicleBase
    {
        Guid VehicleId { get; set; }
        string Name { get; set; }
        string RegistrationNumber { get; set; }
    }
}
