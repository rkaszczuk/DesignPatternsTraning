using System.Collections.Generic;

namespace LeasingSystemToRefactor.Finance
{
    public interface ILeasingPaymentsCalculator
    {
        List<decimal> Calculate();
    }
}