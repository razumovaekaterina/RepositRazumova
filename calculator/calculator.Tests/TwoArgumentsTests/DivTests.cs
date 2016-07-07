using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class DivTests
    {
        [Test]
        public void DivTest()
        {
            ITwoArgumentCalculator calculator = new Div();
            double result = calculator.Calculate(2, 5);
            Assert.AreEqual(10, result);
        }  
    }
}