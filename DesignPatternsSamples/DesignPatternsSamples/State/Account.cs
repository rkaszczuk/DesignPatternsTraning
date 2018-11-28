using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.State
{
    public class Account
    {
        public decimal Balance { get; set; }
        private AccountState accountState;
        public Account()
        {
            accountState = new RegularAccountState(this); 
        }
        public void SetAccountState(AccountState accountState)
        {
            this.accountState = accountState;
        }
        public void Deposit(decimal amount)
        {
            accountState.Deposit(amount);
        }
        public void Withdraw(decimal amount)
        {
            accountState.Withdraw(amount);
        }
    }
}
