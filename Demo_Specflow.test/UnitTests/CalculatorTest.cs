using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo_Specflow.test.UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void Add_50and70_120()
        {
            this.calculator.Add(50, 70);
            Assert.AreEqual(120, this.calculator.Result);
        }
    }
}
