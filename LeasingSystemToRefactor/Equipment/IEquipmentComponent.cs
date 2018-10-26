using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Equipment
{
    public interface IEquipmentComponent
    {
        decimal GetPackagePrice();
        List<string> GetEquipmentList();
    }
}
