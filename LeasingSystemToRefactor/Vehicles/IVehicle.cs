using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Vehicles
{
    public interface IVehicle
    {
        int Id { get; set; }
        decimal Price { get; set; }
        string Color { get; set; }
    }
}
