using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class PowTests
    {
        [Test]
        public void PowTest()
        {
            ITwoArgumentCalculator calculator = new Pow();
            double result = calculator.Calculate(2, 3);
            Assert.AreEqual(8, result);
        }
    }
}