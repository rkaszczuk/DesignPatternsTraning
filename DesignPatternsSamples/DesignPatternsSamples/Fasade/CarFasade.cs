using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Fasade
{
    public class CarFasade
    {
        private Car car = new Car();
        public void Faster()
        {
            car.SetCurrentSpeed(car.GetCurrentSpeed() + 10);
            
        }
        public void Slower()
        {
            if (car.GetCurrentSpeed() > 0)
            {
                car.SetCurrentSpeed(car.GetCurrentSpeed() - 10);
            }
        }
    }
}
