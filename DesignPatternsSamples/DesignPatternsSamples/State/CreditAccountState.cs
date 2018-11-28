using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.State
{
    public class CreditAccountState : AccountState
    {
        public CreditAccountState(Account account) : base(account)
        {
        }

        public override void Deposit(decimal amount)
        {
            account.Balance += amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Nie można wypłacić pieniędzy. Ujemne saldo");
            CheckState();
        }
    }
}
