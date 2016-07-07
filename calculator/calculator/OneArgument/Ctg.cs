using System;

namespace calculator.OneArgument
{
    public class Ctg:IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            if (Math.Sin(first) == 0)
            {
                throw new Exception("-");
            }
            return 1/Math.Tan(first);
        }
    }
}