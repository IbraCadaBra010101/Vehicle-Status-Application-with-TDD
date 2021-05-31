using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.VehicleStatusProcessor
{
    public class VehicleStatusProcessor : IVehicleStatusProcessor
    {
        public VehicleStatusProcessor()
        {

        }

        public Task<TransportationCompanyRequest> AddTransportationCompany(TransportationCompanyRequest transportationCompany)
        {
            throw new NotImplementedException();
        }

        public Task<TransportationCompanyRequest> AddVehicleToCompany(int companyId, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> GetCustomerVehicles(int CompanyId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> GetVehiclesByConnectionStatus(VehicleStatusEnum currentStatus)
        {
            throw new NotImplementedException();
        }
    }
}
