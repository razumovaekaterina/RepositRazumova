using System;

namespace calculator
{
    public class Cos:IOneArgumentCalculator 
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}