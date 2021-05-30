using System;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core
{
    public class TransportationCompany 
    {
        int Id { get; set; }
        string Name { get; set; }
        Address Address { get; set; } 
    }
}
