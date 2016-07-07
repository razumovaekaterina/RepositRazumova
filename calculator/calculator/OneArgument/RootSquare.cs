using System;

namespace calculator.OneArgument
{
    public class RootSquare:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (first < 0)
            {
                throw new Exception("Корень из отрицательного числа");
            }
            return Math.Sqrt(first);
        }
    }
}