using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTest()
        {
            //AAA: arrange, act, assert.

            //1) Arrange.
            Calculator calculator = new Calculator();
            int result = 0;

            //2) Act.
            result = calculator.add(2, 3);

            //3) Assert.
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void multiplyTest()
        {
            //AAA: arrange, act, assert.

            //1) Arrange.
            Calculator calculator = new Calculator();
            int result = 0;

            //2) Act.
            result = calculator.multiply(2, 3);

            //3) Assert.
            Assert.AreEqual(result, 6);
        }
    }
}
