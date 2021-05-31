using System.Collections.Generic;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.VehicleStatusProcessor
{
    public interface IVehicleStatusProcessor
    {
        TransportationCompany GetCompanyOverview();
        IEnumerable<Vehicle> GetVehiclesConnectionStatus(VehicleStatusEnum currentStatus);
        IEnumerable<Vehicle> GetCustomerVehicles(int CompanyId); 
    }
} 
