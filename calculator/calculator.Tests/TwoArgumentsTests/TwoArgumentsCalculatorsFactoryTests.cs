using System;
using NUnit.Framework;

namespace calculator.Tests
{
    [TestFixture]
    public class TwoArgumentsCalculatorsFactoryTests
    {
        [TestCase("Add", typeof(Add))]
        [TestCase("Sub", typeof(Sub))]
        [TestCase("Mul", typeof(Mul))]
        [TestCase("Div", typeof(Div))]
        [TestCase("Pow", typeof(Pow))]
        [TestCase("Root", typeof(Root))]
        public void MulTest(string name, Type type)
        {
            ITwoArgumentCalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}