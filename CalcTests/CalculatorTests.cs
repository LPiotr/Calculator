using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var calculator = new Calculator();
            var result = calculator.Add(10, 15);

            Assert.AreEqual<double>(25, result);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.Fail();
        }
    }
}