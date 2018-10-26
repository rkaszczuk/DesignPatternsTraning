namespace LeasingSystemToRefactor.Finance
{
    public interface IInterestRateCalculator
    {
        decimal CalculateInterestRate(string ccy, decimal commission, int numberOfMonths);
    }
}