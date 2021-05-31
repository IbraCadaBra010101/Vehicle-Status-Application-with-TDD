using VehicleStatus.Core.Domain;
using VehicleStatus.Core.Domain.Vehicles;

namespace VehicleStatus.Core.DataInterface
{
    public interface IVehicleRepository
    {
        void RemoveVehicle(Vehicle vehicle); 
        void AddVehicle(VehicleRequest vehicle);
        void EditVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
    }
}
