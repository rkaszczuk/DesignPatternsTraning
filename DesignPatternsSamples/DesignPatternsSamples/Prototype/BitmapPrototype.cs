using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Prototype
{
    public abstract class BitmapPrototype
    {
        private byte[] bitmapData;
        public BitmapPrototype(byte[] bitmapData)
        {
            this.bitmapData = bitmapData;
        }
        public abstract BitmapPrototype Clone();
    }
}
