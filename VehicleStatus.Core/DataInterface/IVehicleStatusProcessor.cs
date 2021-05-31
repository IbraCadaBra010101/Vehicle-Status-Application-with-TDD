using System.Collections.Generic;
using System.Threading.Tasks;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.VehicleStatusProcessor
{
    public interface IVehicleStatusProcessor
    {
        void AssignConnectionStatusToVehicles(IEnumerable<Vehicle> vehicles);
        Task<IEnumerable<Vehicle>> GetVehiclesByConnectionStatus(IEnumerable<Vehicle> vehicles);
        Task<IEnumerable<T>> GetOverView<T>(IEnumerable<Vehicle> vehicles, IEnumerable<TransportationCompany> transportationCompanies);
    }
}
