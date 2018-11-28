using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public interface IOfferService
    {
        Offer CreateOffer(IVehicle vehicle, EquipmentPackage equipmentPackage, OfferFinancialDetails offerFinancialDetails);

    }
}
