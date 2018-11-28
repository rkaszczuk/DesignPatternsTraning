using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.State
{
    public abstract class AccountState
    {
        protected Account account;
        public AccountState(Account account)
        {
            this.account = account;
        }
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
        public void CheckState()
        {
            if(account.Balance < 0)
            {
                account.SetAccountState(new CreditAccountState(account));
            }
            else
            {
                account.SetAccountState(new RegularAccountState(account));
            }
        }
    }
}
