using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class RootSquareTests
    {
        [Test]
        public void RootSquareTest()
        {
            IOneArgumentCalculator calculator = new RootSquare();
            double result = calculator.Calculate(4);
            Assert.AreEqual(2, result);
        }
    }
}