using System;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class CtgTests
    {
        [Test]
        public void CtgTest()
        {
            IOneArgumentCalculator calculator = new Ctg();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.64209, result);

        }
    }
}