using System;

namespace calculator
{
    public class PowSquare:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}