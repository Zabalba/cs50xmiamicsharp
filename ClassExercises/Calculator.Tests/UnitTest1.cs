using System;
using Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            TypicalCalculator c = new TypicalCalculator();
            Assert.AreEqual(5, c.Add(3, 2));
        }
        [TestMethod]
        public void Multiply()
        {
            TypicalCalculator c = new TypicalCalculator();
            Assert.AreEqual(6, c.Multiply(3, 2));
        }
        public void Subtract()
        {
            TypicalCalculator c = new TypicalCalculator();
            Assert.AreEqual(1, c.Subtract(3, 2));
        }
        public void Divide()
        {
            TypicalCalculator c = new TypicalCalculator();
            Assert.AreEqual(1.5, c.Divide(3, 2));
        }
    }
}
