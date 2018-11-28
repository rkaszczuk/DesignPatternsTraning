using LeasingSystemToRefactor.Equipment;
using LeasingSystemToRefactor.Finance;
using LeasingSystemToRefactor.Parser;
using LeasingSystemToRefactor.Vehicles;
using LeasingSystemToRefactor.Vehicles.Cars;
using LeasingSystemToRefactor.Vehicles.Trucks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public class Offer
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsCompleted { get; set; }
        public IVehicle Vehicle { get; set; }
        public EquipmentPackage EquipmentPackage { get; set; }
        public List<decimal> Payments { get; set; }
        public OfferFinancialDetails OfferFinancialDetails { get; set; }

        public void CalculatePayments()
        {
            var interestRateCalculator = new InterestRateCalculator();
            var interestRate = interestRateCalculator.CalculateInterestRate(OfferFinancialDetails.Ccy, OfferFinancialDetails.Commission, OfferFinancialDetails.NumberOfMonths);
            

            if(Vehicle is CarBase)
            {
                var car = Vehicle as CarBase;
                var leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForCar(interestRate, OfferFinancialDetails.NumberOfMonths, car.NumberOfDoors, car.Price + EquipmentPackage.GetPackagePrice(), OfferFinancialDetails.OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
            else if(Vehicle.GetType() == typeof(TruckBase))
            {
                var truck = Vehicle as TruckBase;
                var leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForTruck(interestRate, OfferFinancialDetails.NumberOfMonths, truck.NumberOfAxles, truck.MaximumWeight, truck.Price + EquipmentPackage.GetPackagePrice(), OfferFinancialDetails.OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
        }
        
    }
}
