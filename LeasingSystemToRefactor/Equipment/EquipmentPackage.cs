using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Equipment
{
    public class EquipmentPackage : IEquipmentComponent
    {
        public int Id { get; set; }
        public string EquipmentPackageName { get; set; }
        public List<IEquipmentComponent> EquipmentComponents { get; set; }
        public EquipmentPackage()
        {
            EquipmentComponents = new List<IEquipmentComponent>();
        }

        public decimal GetPackagePrice()
        {
            var result = 0M;
            foreach (var component in EquipmentComponents)
            {
                result += component.GetPackagePrice();
            }
            return result;
        }        

        public List<string> GetEquipmentList()
        {
            var result = new List<string>();
            foreach (var component in EquipmentComponents)
            {
                result.AddRange(component.GetEquipmentList());
            }
            return result;
        }
    }
}
