using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;
        public int getState()
        {
            return state;
        }
        public void setState(int state)
        {
            this.state = state;
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
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
