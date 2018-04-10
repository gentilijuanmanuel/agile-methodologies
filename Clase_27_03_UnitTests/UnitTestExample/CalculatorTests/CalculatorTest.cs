using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestExample;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void addTest()
        {
            //AAA
            //Arrange
            Calculator calculator = new Calculator();
            int result;



            //Act
            result = calculator.add(1, 2);

            //Assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void multiplyTest()
        {
            //AAA

            //Arrange
            Calculator calculator = new Calculator();
            int result;

            //Act
            result = calculator.multiply(2, 3);

            //Assert
            Assert.AreEqual(result, 6);
        }
    }
}
