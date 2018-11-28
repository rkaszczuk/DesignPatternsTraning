using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Finance;
using LeasingSystemToRefactor.Repositories;
using LeasingSystemToRefactor.Vehicles;
using LeasingSystemToRefactor.Vehicles.Cars;
using LeasingSystemToRefactor.Vehicles.Trucks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public class OfferService : IOfferService
    {
        OfferRepository offerRepository;
        IOfferBuilder offerBuilder;
        IInterestRateCalculator interestRateCalculator;

        public OfferService(OfferRepository offerRepository, IOfferBuilder offerBuilder, IInterestRateCalculator interestRateCalculator)
        {
            this.offerRepository = offerRepository;
            this.offerBuilder = offerBuilder;
            this.interestRateCalculator = interestRateCalculator;
        }

        public Offer CreateOffer(IVehicle vehicle, EquipmentPackage equipmentPackage, OfferFinancialDetails offerFinancialDetails)
        {
            var offer = offerBuilder.SetVehicle(vehicle).SetFinancialDetails(offerFinancialDetails).SetEquipmentPackage(equipmentPackage).Build();
            offer.Payments = GetPayments(vehicle, equipmentPackage, offerFinancialDetails);
            return offer;
        }
        
       
        private List<decimal> GetPayments(IVehicle vehicle, EquipmentPackage equipmentPackage, OfferFinancialDetails offerFinancialDetails)
        {
            LeasingPaymentsCalculator leasingPaymentsCalculator = null;
            var interestRate = interestRateCalculator.CalculateInterestRate(offerFinancialDetails.Ccy, offerFinancialDetails.Commission, offerFinancialDetails.NumberOfMonths);
            if (vehicle is CarBase)
            {
                var car = vehicle as CarBase;
                leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForCar(interestRate, offerFinancialDetails.NumberOfMonths, car.NumberOfDoors, car.Price + equipmentPackage.GetPackagePrice(), offerFinancialDetails.OwnContribution);
            }
            else if (vehicle.GetType() == typeof(TruckBase))
            {
                var truck = vehicle as TruckBase;
                leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForTruck(interestRate, offerFinancialDetails.NumberOfMonths, truck.NumberOfAxles, truck.MaximumWeight, truck.Price + equipmentPackage.GetPackagePrice(), offerFinancialDetails.OwnContribution);
            }
            return leasingPaymentsCalculator.Calculate();
        }

    }
}
