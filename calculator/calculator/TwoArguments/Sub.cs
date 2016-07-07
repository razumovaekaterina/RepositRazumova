namespace calculator
{
    public class Sub : ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}