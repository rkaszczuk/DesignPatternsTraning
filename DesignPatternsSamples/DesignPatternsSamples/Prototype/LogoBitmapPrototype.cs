using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Prototype
{
    public class LogoBitmapPrototype : BitmapPrototype
    {
        public LogoBitmapPrototype() : base(new byte[] { 1, 2, 3, 4 })
        {
        }

        public override BitmapPrototype Clone()
        {
            return (BitmapPrototype)this.MemberwiseClone();
        }
    }
}
