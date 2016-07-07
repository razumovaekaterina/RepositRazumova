using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class RootTests
    {
        [Test]
        public void RootTest()
        {
            ITwoArgumentCalculator calculator = new Root();
            double result = calculator.Calculate(8, 3);
            Assert.AreEqual(2, result);
        }
    }
}