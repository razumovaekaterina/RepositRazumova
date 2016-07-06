using System;

namespace calculator
{
    public class OneArgumentCalculatorFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string calculateName)
        {
            switch (calculateName)
            {
                case "BtnSin":
                    return new Sin();
                case "BtnCos":
                    return new Cos();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
 
}