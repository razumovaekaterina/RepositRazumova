using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    [TestFixture]
    public class RootSquareTests
    {
        [TestCase(1, 1)]
        [TestCase(16, 4)]
        [TestCase(7744, 88)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new RootSquare();
            var result = calculator.Calculate(first);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivisionByZeroTest()
        {
            var calculator = new RootSquare();
            Assert.Throws<Exception>(() => calculator.Calculate(-12));
        }
    }
}