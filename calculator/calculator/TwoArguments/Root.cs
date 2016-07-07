using System;

namespace calculator.TwoArguments
{
    public class Root:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            if (first < 0)
            {
                throw new Exception("Корень из отрицательного числа");
            }
            return Math.Pow(first, 1/second);
        }
    }
}