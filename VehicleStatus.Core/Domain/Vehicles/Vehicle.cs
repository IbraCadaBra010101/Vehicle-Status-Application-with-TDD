using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStatus.Core.Domain
{
    public class Vehicle
    {
        int Id { get; set; }
        public enum ConnectionStatus { Connected, Offline } 
    } 
} 
