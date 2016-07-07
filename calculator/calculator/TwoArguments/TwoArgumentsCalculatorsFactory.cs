using System;

namespace calculator.TwoArguments
{
    public static class TwoArgumentsCalculatorsFactory
    {
        public static ITwoArgumentCalculator CreateCalculator(string calculateName)
        {
            switch (calculateName)
            {
                case "BtnAdd":
                    return new Add();
                case "BtnSub":
                    return new Sub();
                case "BtnMul":
                    return new Mul();
                case "BtnDiv":
                    return new Div();
                case "BtnPow":
                    return new Pow();
                case "BtnRoot":
                    return new Root();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}