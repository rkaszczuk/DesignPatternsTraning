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
        public string Ccy { get; set; }
        public decimal Commission { get; set; }
        public int NumberOfMonths { get; set; }
        public decimal OwnContribution { get; set; }
        public void CalculatePayments()
        {
            var interestRateCalculator = new InterestRateCalculator();
            var interestRate = 0M;
            if(Ccy == "PLN")
            {
                interestRate = interestRateCalculator.CalculateInterestRatePLN(Commission, NumberOfMonths);
            }
            else
            {
                interestRate = interestRateCalculator.CalculateInterestRatePLN(Commission, NumberOfMonths);
            }

            if(Vehicle.GetType() == typeof(CarBase))
            {
                var car = Vehicle as CarBase;
                var leasingPaymentsCalculator = new LeasingPaymentsCalculator(interestRate, NumberOfMonths, car.NumberOfDoors, false, car.Price + EquipmentPackage.GetPackagePrice(), OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
            else if(Vehicle.GetType() == typeof(TruckBase))
            {
                var truck = Vehicle as TruckBase;
                var leasingPaymentsCalculator = new LeasingPaymentsCalculator(interestRate, NumberOfMonths, truck.NumberOfAxles, true, truck.MaximumWeight, truck.Price + EquipmentPackage.GetPackagePrice(), OwnContribution);
                Payments = leasingPaymentsCalculator.Calculate();
            }
        }
        
    }
}
