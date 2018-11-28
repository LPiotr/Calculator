using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Assert.AreEqual(25, result);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var calculator = new Calculator();
            var result = calculator.Substract(10, 15);

            Assert.AreEqual(-5, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var calculator = new Calculator();
            var result = calculator.Multiply(10, 15);

            Assert.AreEqual(150, result);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calculator = new Calculator();
            var result = calculator.Divide(150, 10);

            Assert.AreEqual(15, result);
        }
    }
}