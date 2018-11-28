using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public static class ObjectDbContext
    {
        public static List<Offer> Offers { get; set; } = new List<Offer>();
        public static List<EquipmentPackage> EquipmentPackages { get; set; } = new List<EquipmentPackage>();
        public static List<IVehicle> Vehicles { get; set; } = new List<IVehicle>();
    }
}
