using System;

namespace calculator
{
    public class Pow:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}