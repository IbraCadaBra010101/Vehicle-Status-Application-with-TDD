using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using VehicleStatus.Core.Domain;

namespace VehicleStatus.Core
{
    [Table("Company", Schema = "Vehicles")]
    public class TransportationCompany
    {
        int Id { get; set; }
        string CompanyName { get; set; }
        string StreetName { get; set; }
        string ZipCode { get; set; }
        string City { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
