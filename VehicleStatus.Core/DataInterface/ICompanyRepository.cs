using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core.DataInterface
{
    public interface ICompanyRepository
    {
        void RemoveCompany(TransportationCompany transportationCompany);
        void AddCompany(TransportationCompanyRequest vehicle);
        void EditCompany(TransportationCompany vehicle);
        void DeleteCompany(TransportationCompany vehicle);
    }
}
