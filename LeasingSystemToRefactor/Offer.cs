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

            if(Vehicle.GetType() == typeof(CarBase))
            {
                var car = Vehicle as CarBase;
                var leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForCar(interestRate, NumberOfMonths, car.NumberOfDoors, car.Price + EquipmentPackage.GetPackagePrice(), OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
            else if(Vehicle.GetType() == typeof(TruckBase))
            {
                var truck = Vehicle as TruckBase;
                var leasingPaymentsCalculator = LeasingPaymentsCalculator.GetLeasingPaymentCalculatorForTruck(interestRate, NumberOfMonths, truck.NumberOfAxles, truck.MaximumWeight, truck.Price + EquipmentPackage.GetPackagePrice(), OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
        }
        
    }
}
