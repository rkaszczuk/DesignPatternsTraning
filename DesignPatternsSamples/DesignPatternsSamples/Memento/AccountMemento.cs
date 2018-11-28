using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Memento
{
    public class AccountMemento
    {
        public decimal Ammount { get; set; }
        public string CCY { get; set; }
        public DateTime DateTime { get; set; }
    }
}
