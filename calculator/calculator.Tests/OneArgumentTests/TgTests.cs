using System;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class TgTests
    {
        [Test]
        public void TgTest()
        {
            IOneArgumentCalculator calculator = new Tg();
            double result = calculator.Calculate(1);
            Assert.AreEqual(1.55741, result);

        }
    }
}