using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_03_04;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddEmptyStringTest()
        {
            //AAA
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result;

            //Act
            result = calculator.add("");

            //Assert
            Assert.AreEqual(result, 0);

        }

        [TestMethod]
        public void AddOneNumberStringTest()
        {
            //AAA
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result;

            //Act
            result = calculator.add("2");

            //Assert
            Assert.AreEqual(result, 2);
        }


        [TestMethod]
        public void AddTwoNumbersStringTest()
        {
            //AAA
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result;

            //Act
            result = calculator.add("2,4");

            //Assert
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void AddNNumbersStringTest()
        {
            //AAA
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result;

            //Act
            result = calculator.add("2,4,6");

            //Assert
            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void AddNewDelimitersTest()
        {
            //AAA
            //Arrange
            StringCalculator calculator = new StringCalculator();
            int result;

            //Act
            result = calculator.add("2,4\n6");

            //Assert
            Assert.AreEqual(result, 12);
        }
    }
}
