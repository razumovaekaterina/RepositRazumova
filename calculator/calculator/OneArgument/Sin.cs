using System;

namespace calculator.OneArgument
{
    public class Sin:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}