using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public class OfferBuilder : IOfferBuilder
    {
        private IVehicle vehicle;
        private EquipmentPackage equipmentPackage;
        private OfferFinancialDetails financialDetails;

        public OfferBuilder SetVehicle(IVehicle vehicle)
        {
            this.vehicle = vehicle;
            return this;
        }
        public OfferBuilder SetEquipmentPackage(EquipmentPackage equipmentPackage)
        {
            this.equipmentPackage = equipmentPackage;
            return this;
        }
        public OfferBuilder SetFinancialDetails(OfferFinancialDetails offerFinancialDetails)
        {
            this.financialDetails = offerFinancialDetails;
            return this;
        }
        public Offer Build()
        {
            var offer = new Offer();
            offer.OfferFinancialDetails = this.financialDetails;
            offer.Vehicle = this.vehicle;
            offer.EquipmentPackage = this.equipmentPackage;
            return offer;
        }
    }
}
