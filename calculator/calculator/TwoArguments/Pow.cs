using System;

namespace calculator.TwoArguments
{
    public class Pow:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}