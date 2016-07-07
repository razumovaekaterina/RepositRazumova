using System;
using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.TwoArgumentsTests
{
    [TestFixture]
    public class TwoArgumentsCalculatorsFactoryTests
    {
        [TestCase("BtnAdd", typeof(Add))]
        [TestCase("BtnSub", typeof(Sub))]
        [TestCase("BtnMul", typeof(Mul))]
        [TestCase("BtnDiv", typeof(Div))]
        [TestCase("BtnPow", typeof(Pow))]
        [TestCase("BtnRoot", typeof(Root))]
        public void MulTest(string name, Type type)
        {
            ITwoArgumentCalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        } 
    }
}