using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Vehicles.Trucks
{
    public abstract class TruckBase : IVehicle
    {
        public decimal Price { get; set; }
        public int NumberOfAxles { get; set; }
        public int MaximumWeight { get; set; }
        public string Color { get; set; }
        public int Id { get; set; }
    }
}
