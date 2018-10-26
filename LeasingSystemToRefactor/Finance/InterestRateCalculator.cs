using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Finance
{
    public class InterestRateCalculator : IInterestRateCalculator
    {
        const decimal Wibor3MRate = 1.72M;
        const decimal Wibor6MRate = 1.79M;
        const decimal Libor3MRate = -0.3509M;
        const decimal Libor6MRate = -0.3251M;
        public decimal CalculateInterestRate(string ccy, decimal commission, int numberOfMonths)
        {
            if (ccy == "PLN")
            {
                return CalculateInterestRatePLN(commission, numberOfMonths);
            }
            else
            {
                return CalculateInterestRateNonPLN(commission, numberOfMonths);
            }
        }
        private decimal CalculateInterestRateNonPLN(decimal commission, int numberOfMonths)
        {
            if (numberOfMonths <= 3)
            {
                return Libor3MRate + commission;
            }
            else
            {
                return Libor6MRate + commission;
            }
        }

        private decimal CalculateInterestRatePLN(decimal commission, int numberOfMonths)
        {

            if (numberOfMonths <= 3)
            {
                return Wibor3MRate + commission;
            }
            else
            {
                return Wibor6MRate + commission;
            }
        }

    }
}
