using System;

namespace calculator
{
    public class Tg:IOneArgumentCalculator

    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}