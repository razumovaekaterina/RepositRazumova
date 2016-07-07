using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class CtgTests
    {

        [TestCase(1, 0.64209)]
        [TestCase(-1, -0.64209)]
        [TestCase(9, -2.21085)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Ctg();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
     
    }
}