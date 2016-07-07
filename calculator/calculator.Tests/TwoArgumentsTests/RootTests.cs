using System;
using calculator.OneArgument;
using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class RootTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(64, 3, 4)]
        [TestCase(46656, 6, 6)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Root();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.000001);
        }
        [Test]
        public void DivisionByZeroTest()
        {
            var calculator = new Root();
            Assert.Throws<Exception>(() => calculator.Calculate(-12,2));
        }
    }
}