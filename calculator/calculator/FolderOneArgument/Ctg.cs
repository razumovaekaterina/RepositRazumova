using System;

namespace calculator
{
    public class Ctg:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}