using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer
{
    public abstract class Observer
    {
        public Observer(Subject subject)
        {
            this.subject = subject;
        }
        protected Subject subject;
        public abstract void Update();
    }
}
