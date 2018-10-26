using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Finance
{
    public class LeasingPaymentsCalculator
    {
        private decimal InterestRate { get; set; }
        private int NumberOfMonths { get; set; }
        //Only for Cars
        private int NumberOfDoors { get; set; }
        //Only for Trucks
        private int NumberOfAxles { get; set; }
        private bool IsTruck { get; set; }
        //Only for Trucks
        private int MaximumWeight { get; set; }
        private decimal VehicleValue { get; set; }
        private decimal OwnContributionValue { get; set; }
        private LeasingPaymentsCalculator()
        {
                
        }
        public static LeasingPaymentsCalculator GetLeasingPaymentCalculatorForCar
            (decimal interestRate, int numberOfMonths, int numberOfDoors, decimal vehicleValue, decimal ownContributionValue)
        {
            return new LeasingPaymentsCalculator()
            {
                InterestRate = interestRate,
                NumberOfDoors = numberOfDoors,
                NumberOfMonths = numberOfMonths,
                IsTruck = false,
                OwnContributionValue = ownContributionValue,
                VehicleValue = vehicleValue
            };
        }
        public static LeasingPaymentsCalculator GetLeasingPaymentCalculatorForTruck
            (decimal interestRate, int numberOfMonths, int numberOfAxles, int maximumWeight, decimal vehicleValue, decimal ownContributionValue)
        {
            return new LeasingPaymentsCalculator()
            {
                InterestRate = interestRate,
                MaximumWeight = maximumWeight,
                NumberOfAxles = numberOfAxles,
                NumberOfMonths = numberOfMonths,
                IsTruck = false,
                OwnContributionValue = ownContributionValue,
                VehicleValue = vehicleValue
            };
        }
        public List<decimal> Calculate()
        {
            decimal riskFactor = 1;
            if (IsTruck)
            {
                if(MaximumWeight < 12000)
                {
                    riskFactor *= 1.1m;
                }
                if(NumberOfAxles > 3)
                {
                    riskFactor *= 1.5m;
                }
            }
            else if (!IsTruck)
            {
                if (NumberOfDoors < 4)
                {
                    riskFactor *= 1.2m;
                }

            }
            

            var totalPayment = VehicleValue * (1 + 12 / NumberOfMonths) * InterestRate * riskFactor;
            List<decimal> result = new List<decimal>();
            for (int i = 0; i < NumberOfMonths; i++)
            {
                result.Add(totalPayment / NumberOfMonths);
            }
            return result;
        }

    }
}
