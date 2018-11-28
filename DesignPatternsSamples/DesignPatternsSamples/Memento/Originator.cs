using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Memento
{
    public class Originator
    {
        public decimal Ammount { get; set; }
        public string CCY { get; set; }
        public AccountMemento SaveState()
        {
            return new AccountMemento() { Ammount = Ammount, CCY = CCY, DateTime = DateTime.Now };
        }
        public void LoadState(AccountMemento accountMemento)
        {
            Ammount = accountMemento.Ammount;
            CCY = accountMemento.CCY;
        }
    }
}
