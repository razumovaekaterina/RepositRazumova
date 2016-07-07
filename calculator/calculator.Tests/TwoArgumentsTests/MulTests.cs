using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class MulTests
    {
        [Test]
        public void MulTest()
        {
            ITwoArgumentCalculator calculator = new Mul();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(10, result);
        } 
    }
}