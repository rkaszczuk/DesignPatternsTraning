using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer.AccountObserver
{
    public class AccountSubject
    {
        private List<Observer> observers = new List<Observer>();
        private decimal balance;
        public void SetBalance(decimal balance)
        {
            this.balance = balance;
            Notify();
        }
        public decimal GetBalance()
        {
            return balance;
        }
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

    }
}
