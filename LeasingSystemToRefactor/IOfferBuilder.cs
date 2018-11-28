using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Vehicles;

namespace LeasingSystemToRefactor
{
    public interface IOfferBuilder
    {
        Offer Build();
        OfferBuilder SetEquipmentPackage(EquipmentPackage equipmentPackage);
        OfferBuilder SetFinancialDetails(OfferFinancialDetails offerFinancialDetails);
        OfferBuilder SetVehicle(IVehicle vehicle);
    }
}