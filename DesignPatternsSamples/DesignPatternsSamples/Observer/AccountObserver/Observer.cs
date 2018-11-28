using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer.AccountObserver
{
    public abstract class Observer
    {
        public Observer(AccountSubject subject)
        {
            this.subject = subject;
        }
        protected AccountSubject subject;
        public abstract void Update();
    }
}
