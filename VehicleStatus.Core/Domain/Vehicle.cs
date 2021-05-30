using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStatus.Core.Domain
{
    public class Vehicle
    {
        int Id { get; set; }
        Guid VehicleId { get; set; }
        string Name { get; set; }
        string RegistrationNumber { get; set; }
        TransportationCompany Company { get; set; }
    }
}
