using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeRefactoringLabb.Tests
{
    [TestClass()]
    public class TopListTests
    {
        [TestMethod()]
        public void WriteScoreTest() {
            string nameTest = "Testsson";
            int numberOfGuessesTest = 4;

            Assert.AreEqual("Score Added", TopList.WriteScore(nameTest, numberOfGuessesTest));
        }
        [TestMethod()]
        public void ShowResultsTest() {
            // Inte klar...
            List<PlayerData> results = new List<PlayerData>();
            string nameTest = "TestarssonStrong";
            int guessesTest = 5;
            PlayerData testPlayer = new PlayerData(nameTest, guessesTest);
            results.Add(testPlayer);
            Assert.AreSame(results[0], testPlayer);
        }
        [TestMethod()]
        public void ResultFormatStringTest() {
            string nameTest = "testsson";
            int numberOfGamesTest = 4;
            double averageTest = 5.5;
            Assert.AreEqual(string.Format("{0,-9}{1,5:D}{2,9:F2}", nameTest, numberOfGamesTest, averageTest), TopList.ResultFormatString(nameTest, numberOfGamesTest, averageTest));
        }
        [TestMethod()]
        public void PlayerScoresStringTest() {
            Assert.AreEqual("Player   games average", TopList.PlayerScoresString());
        }
    }
}