using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor
{
    public class OfferFinancialDetails
    {
        public string Ccy { get; set; }
        public decimal Commission { get; set; }
        public int NumberOfMonths { get; set; }
        public decimal OwnContribution { get; set; }
    }
}
