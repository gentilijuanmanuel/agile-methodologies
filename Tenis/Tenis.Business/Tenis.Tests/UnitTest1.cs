using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenis.Business;

namespace Tenis.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void matchBeginTest()
        {
            //Arrange
            Match match = new Match();

            //Act

            //Assert
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(match.scoreboard[i, 0], 0);
            }
        }

        [TestMethod]
        public void addPointTest()
        {
            //Arrange
            Match match1 = new Match();
            int result = 0;

            //Act
            result = match1.addPoint(1);

            //Assert
            Assert.AreEqual(result, 1);
        }
    }

    
}
