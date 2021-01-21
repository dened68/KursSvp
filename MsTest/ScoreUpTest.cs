using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestKurs
{
    [TestClass]
    public class ScoreUpTest
    {

        [TestMethod]
        public void TestMethodgetScore()
        {
            //arange
            int gameScore = 50;
            int gameLevel = 1;

            //act
            getScore(gameScore, gameLevel);

            //assert
            int actual = getScore(gameScore, gameLevel);
            Assert.AreEqual(100, actual);
        }

        public int getScore(int gameScore, int gameLevel)
        {
            gameScore += 50 * gameLevel;
            return gameScore;
        }



    }
}
