using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class PowTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-4, 3, -64)]
        [TestCase(-6, 6, 46656)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Pow();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}