using System;

namespace calculator
{
    public class Sin:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}