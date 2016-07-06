using System;

namespace calculator
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
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}