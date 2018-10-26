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

        public LeasingPaymentsCalculator(decimal interestRate, int numberOfMonths, int numberOfDoors, int numberOfAxles, bool isTruck, int maximumWeight, decimal vehicleValue, decimal ownContributionValue)
        {
            InterestRate = interestRate;
            NumberOfMonths = numberOfMonths;
            NumberOfDoors = numberOfDoors;
            NumberOfAxles = numberOfAxles;
            IsTruck = isTruck;
            MaximumWeight = maximumWeight;
            VehicleValue = vehicleValue;
            OwnContributionValue = ownContributionValue;
        }

        public LeasingPaymentsCalculator(decimal interestRate, int numberOfMonths, int numberOfDoors, bool isTruck, decimal vehicleValue, decimal ownContributionValue)
        {
            InterestRate = interestRate;
            NumberOfMonths = numberOfMonths;
            NumberOfDoors = numberOfDoors;
            IsTruck = isTruck;
            VehicleValue = vehicleValue;
            OwnContributionValue = ownContributionValue;
        }

        public LeasingPaymentsCalculator(decimal interestRate, int numberOfMonths, int numberOfAxles, bool isTruck, int maximumWeight, decimal vehicleValue, decimal ownContributionValue)
        {
            InterestRate = interestRate;
            NumberOfMonths = numberOfMonths;
            NumberOfAxles = numberOfAxles;
            IsTruck = isTruck;
            MaximumWeight = maximumWeight;
            VehicleValue = vehicleValue;
            OwnContributionValue = ownContributionValue;
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
