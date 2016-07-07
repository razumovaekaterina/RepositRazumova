namespace calculator
{
    public class Mul:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return first*second;
        }
    }
}