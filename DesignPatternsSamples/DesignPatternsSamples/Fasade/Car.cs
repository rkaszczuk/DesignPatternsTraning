using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Fasade
{
    public class Car
    {
        private int currentGear = 1;
        private int currentSpeed = 0;
        public void SetCurrentGear(int newGear)
        {
            currentGear = newGear;
        }
        public void SetCurrentSpeed(int newSpeed)
        {
            currentSpeed = newSpeed;
        }
        public int GetCurrentSpeed()
        {
            return currentSpeed;
        }
    }
}
