using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStatus.Core.Domain
{
    public class Address
    {
        int Id { get; set; }
        string StreetName { get; set; }
        string ZipCode { get; set; }
        string City { get; set; }
    }
}
