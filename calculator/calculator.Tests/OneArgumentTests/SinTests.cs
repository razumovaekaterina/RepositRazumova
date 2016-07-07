using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class SinTests
    {
 
        [TestCase(1, 0.84147)]
        [TestCase(-1, -0.84147)]
        [TestCase(9, 0.41212)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Sin();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}