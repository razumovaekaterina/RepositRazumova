using System;
using System.Windows.Forms;

namespace calculator.TwoArguments
{
    public class Div:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на 0");
            }
            return first/second;
        }
    }
}