using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Memento
{
    public static class MementoUsage
    {
        public static void Run()
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.Ammount = 10;
            var state1 = originator.SaveState();
            careTaker.Add(state1);
            Console.WriteLine(originator.Ammount);
            originator.Ammount = 100;
            var state2 = originator.SaveState();
            careTaker.Add(state2);
            Console.WriteLine(originator.Ammount);
            originator.LoadState(careTaker.Get(state1.DateTime));
            Console.WriteLine(originator.Ammount);
        }
    }
}
