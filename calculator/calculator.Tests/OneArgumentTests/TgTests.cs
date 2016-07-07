using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class TgTests
    {

        [TestCase(1, 1.55741)]
        [TestCase(-1, -1.55741)]
        [TestCase(9, -0.45232)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Tg();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}