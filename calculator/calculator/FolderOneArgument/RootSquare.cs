using System;

namespace calculator
{
    public class RootSquare:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}