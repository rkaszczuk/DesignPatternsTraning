using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer
{
    public class LoggerObserver : Observer
    {
        public LoggerObserver(Subject subject) : base(subject)
        {
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine(subject.getState());
        }
    }
}
