using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Equipment
{
    public class EquipmentItem : IEquipmentComponent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public List<string> GetEquipmentList()
        {
            return new List<string> { Name };
        }

        public decimal GetPackagePrice()
        {
            return Price;
        }
        
    }
}
