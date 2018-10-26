using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Vehicles.Cars
{
    public abstract class CarBase : IVehicle
    {
        public decimal Price { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public int Id { get; set; }
    }
}
