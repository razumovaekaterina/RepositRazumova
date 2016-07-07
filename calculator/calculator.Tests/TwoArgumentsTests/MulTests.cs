using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class MulTests
    {
        [TestCase(-20, -10, 200)]
        [TestCase(14, 2, 28)]
        [TestCase(-5, 100, -500)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Mul();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}