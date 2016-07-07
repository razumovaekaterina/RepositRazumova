using System;

namespace calculator.OneArgument
{
    public class Cos:IOneArgumentCalculator 
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}