using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenis.Business;

namespace Testss
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
            Assert.AreEqual(match.pointsPlayer1, 0);
            Assert.AreEqual(match.pointsPlayer2, 0);
        }

        [TestMethod]
        public void addPointTest()
        {
            //Arrange
            Match match1 = new Match();

            //Act
            match1.addPoint(1);
            match1.addPoint(2);

            //Assert
            Assert.AreEqual(match1.pointsPlayer1, 15);
            Assert.AreEqual(match1.pointsPlayer2, 15);
        }

        [TestMethod]
        public void addGameTest()
        {
            //Arrange
            Match match = new Match();

            //Act
            for (int i = 0; i < 4; i++)
            {
                match.addPoint(1);
            }

            for (int i = 0; i < 4; i++)
            {
                match.addPoint(2);
            }

            //Assert
            Assert.AreEqual(match.scoreboard[0, 0], 1);
            Assert.AreEqual(match.scoreboard[1, 0], 1);
            Assert.AreEqual(match.pointsPlayer1, 0);
            Assert.AreEqual(match.pointsPlayer2, 0);
        }
    }


}
