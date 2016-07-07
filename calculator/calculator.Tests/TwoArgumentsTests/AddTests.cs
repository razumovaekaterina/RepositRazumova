using NUnit.Framework;

namespace calculator.Tests
{
    public class AddTests
    {
        [Test]
        public void AddTest()
        {
            ITwoArgumentCalculator calculator = new Add();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(7, result);
        }
 
    }
}