using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class PowSquareTests
    {
        [TestCase(-1, 1)]
        [TestCase(4, 16)]
        [TestCase(88, 7744)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new PowSquare();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }

    }
}