using System;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosTest()
        {
            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(1);
            Assert.AreEqual(0.54030, result, 0.00001);
        }

    } 
    }
}