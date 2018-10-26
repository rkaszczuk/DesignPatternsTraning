using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Finance
{
    public class InterestRateCalculator
    {
        const decimal Wibor3MRate = 1.72M;
        const decimal Wibor6MRate = 1.79M;
        const decimal Libor3MRate = -0.3509M;
        const decimal Libor6MRate = -0.3251M;

        public decimal CalculateInterestRateNonPLN(decimal commission, int numberOfMonths)
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

        public decimal CalculateInterestRatePLN(decimal commission, int numberOfMonths)
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
