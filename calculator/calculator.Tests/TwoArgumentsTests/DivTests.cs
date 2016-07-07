using System;
using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class DivTests
    {
        [TestCase(-20, -100, 0.2)]
        [TestCase(14, 2, 7)]
        [TestCase(-1000, 100, -10)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Div();
            var result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var calculator = new Div();
            Assert.Throws<Exception>(() => calculator.Calculate(3464, 0));
        }
    }
}