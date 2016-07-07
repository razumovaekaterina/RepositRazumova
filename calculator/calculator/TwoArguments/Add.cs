namespace calculator.TwoArguments
{
    public class Add:ITwoArgumentCalculator
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}