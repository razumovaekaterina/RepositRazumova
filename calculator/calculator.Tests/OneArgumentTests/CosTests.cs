using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CosTests
    {

        [TestCase(1, 0.54030)]
        [TestCase(-1, 0.54030)]
        [TestCase(9, -0.91113)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Cos();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
     
    }
}