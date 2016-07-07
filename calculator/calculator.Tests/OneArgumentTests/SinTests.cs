using System;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void SinTest()
        {
            IOneArgumentCalculator calculator = new Sin();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.84147, result, 0.00001);


        }
    }
}