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
                case "BtnTg":
                    return new Tg();
                case "BtnCtg":
                    return new Ctg();
                case "BtnPowSquare":
                    return new PowSquare();
                case "BtnRootSquare":
                    return new RootSquare();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
 
}