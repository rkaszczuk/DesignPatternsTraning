using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer.AccountObserver
{
    public class LowBalanceObserver : Observer
    {
        public LowBalanceObserver(AccountSubject subject) : base(subject)
        {
        }

        public override void Update()
        {
            if (subject.GetBalance() < 100)
            {
                Console.WriteLine("Mało środków na koncie!");
            }
        }
    }
}
