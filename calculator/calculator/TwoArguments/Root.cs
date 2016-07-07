using System;

namespace calculator
{
    public class Root:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}