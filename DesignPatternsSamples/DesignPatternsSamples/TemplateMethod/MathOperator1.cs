using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.TemplateMethod
{
    public class MathOperator1 : BaseClass
    {
        protected override decimal MathOperation1(decimal input)
        {
            return input - 10;
        }

        protected override decimal MathOperation2(decimal input)
        {
            return input / 10;
        }
    }
}
