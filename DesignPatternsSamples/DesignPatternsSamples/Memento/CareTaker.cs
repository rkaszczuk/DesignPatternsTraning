using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatternsSamples.Memento
{
    public class CareTaker
    {
        private List<AccountMemento> accountMementos = new List<AccountMemento>();
        public void Add(AccountMemento accountMemento)
        {
            accountMementos.Add(accountMemento);
        }
        public AccountMemento Get(DateTime dateTime)
        {
            return accountMementos.FirstOrDefault(x => x.DateTime == dateTime);
        }
    }
}
