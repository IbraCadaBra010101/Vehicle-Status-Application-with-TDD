using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStatus.Core.Domain
{
    public class TransportationCompany : TransportationCompanyBase
    {
        public int Id { get; set; } 
        ICollection<Vehicle> Vehicles { get; set; }
    }
}
