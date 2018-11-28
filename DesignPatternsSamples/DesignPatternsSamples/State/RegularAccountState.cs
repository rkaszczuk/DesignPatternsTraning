using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.State
{
    public class RegularAccountState : AccountState
    {
        public RegularAccountState(Account account) : base(account)
        {
        }

        public override void Deposit(decimal amount)
        {
            account.Balance += amount;
            CheckState();
        }

        public override void Withdraw(decimal amount)
        {
            account.Balance -= amount;
            CheckState();
        }
    }
}
