using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.TemplateMethod
{
    public abstract class BaseClass
    {
        protected abstract decimal MathOperation1(decimal input);
        protected abstract decimal MathOperation2(decimal input);
        protected virtual decimal MathOperation3(decimal input)
        {
            return input * 10;
        }
        protected virtual decimal MathOperation4(decimal input)
        {
            return input + 20;
        }
        public decimal Calculate(decimal input)
        {
            var result = MathOperation1(input);
            result = MathOperation2(result);
            result = MathOperation3(result);
            result = MathOperation4(result);
            return result;
        }
    }
}
