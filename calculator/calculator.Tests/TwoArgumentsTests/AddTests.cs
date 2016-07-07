using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    public class AddTests
    {

        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Add();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}