using System;

namespace calculator.OneArgument
{
    public class Tg:IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            if (Math.Cos(first) == 0)
            {
                throw new Exception("-");
            }
            return Math.Tan(first);
        }
    }
}