using System;
using NUnit.Framework;

namespace calculator.Tests
{
    public class OneArgumentCalculatorsTests
    {
        [TestFixture]
        public class TwoArgumentsCalculatorsFactoryTests
        {
            [TestCase("Sin", typeof(Sin))]
            [TestCase("Cos", typeof(Cos))]
            [TestCase("Tg", typeof(Tg))]
            [TestCase("Ctg", typeof(Ctg))]
            [TestCase("PowSquare", typeof(PowSquare))]
            [TestCase("RootSquare", typeof(RootSquare))]
            public void MulTest(string name, Type type)
            {
                ITwoArgumentCalculator calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(name);
                Assert.IsInstanceOf(type, calculator);
            }
        }
    }
}