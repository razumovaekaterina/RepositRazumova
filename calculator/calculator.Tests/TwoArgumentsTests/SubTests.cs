using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class SubTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, -1)]
        [TestCase(-7, -2, -5)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Sub();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}