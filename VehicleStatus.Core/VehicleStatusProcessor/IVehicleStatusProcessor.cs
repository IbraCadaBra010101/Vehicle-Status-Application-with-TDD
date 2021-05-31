using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.VehicleStatusProcessor
{
    public interface IVehicleStatusProcessor
    {
        Task<TransportationCompanyRequest> AddTransportationCompany(TransportationCompanyRequest transportationCompany); 
        Task<TransportationCompanyRequest> AddVehicleToCompany(int companyId, Vehicle vehicle);   
        Task<IEnumerable<Vehicle>> GetVehiclesByConnectionStatus(VehicleStatusEnum currentStatus);
        Task<IEnumerable<Vehicle>> GetCustomerVehicles(int CompanyId);
    } 
} 
