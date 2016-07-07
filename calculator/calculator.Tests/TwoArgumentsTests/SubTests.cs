using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class SubTests
    {
        [Test]
        public void SubTest()
        {
            ITwoArgumentCalculator calculator = new Sub();
            double result = calculator.Calculate(7, 5);
            Assert.AreEqual(2, result);
        } 
    }
}