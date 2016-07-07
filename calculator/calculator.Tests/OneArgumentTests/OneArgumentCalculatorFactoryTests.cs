using System;
using calculator.OneArgument;
using calculator.TwoArguments;
using NUnit.Framework;

namespace calculator.Tests.OneArgumentTests
{
    public class OneArgumentCalculatorsTests
    {
        [TestFixture]
        public class TwoArgumentsCalculatorsFactoryTests
        {
            [TestCase("BtnSin", typeof(Sin))]
            [TestCase("BtnCos", typeof(Cos))]
            [TestCase("BtnTg", typeof(Tg))]
            [TestCase("BtnCtg", typeof(Ctg))]
            [TestCase("BtnPowSquare", typeof(PowSquare))]
            [TestCase("BtnRootSquare", typeof(RootSquare))]
            public void MulTest(string name, Type type)
            {
                ITwoArgumentCalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type, calculator);
            }
        }
    }
}