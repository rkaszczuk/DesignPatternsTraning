using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer.AccountObserver
{
    public class CreditBalanceObserver : Observer
    {
        public CreditBalanceObserver(AccountSubject subject) : base(subject)
        {
        }

        public override void Update()
        {
            if(subject.GetBalance() < 0)
            {
                Console.WriteLine("Uwaga - ryzyko kredytu. Saldo konta poniżej 0");
            }
        }
    }
}
