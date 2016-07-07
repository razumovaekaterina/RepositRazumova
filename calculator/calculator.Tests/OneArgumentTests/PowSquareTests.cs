using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class PowSquareTests
    {
        [Test]
        public void PowSquareTest()
        {
            IOneArgumentCalculator calculator = new PowSquare();
            double result = calculator.Calculate(4);
            Assert.AreEqual(16, result);
        } 
    }
}