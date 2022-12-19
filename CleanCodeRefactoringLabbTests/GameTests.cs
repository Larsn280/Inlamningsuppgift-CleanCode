using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeRefactoringLabb.Tests
{
    [TestClass()]
    public class GameTests
    {
        Game game = new Game();

        [TestMethod()]
        public void WelcomeTest()
        {
            Assert.AreEqual("Enter your user name:\n", game.Welcome());
        }
        [TestMethod()]
        public void PracticeTest()
        {
            string test = "1223";
            Assert.AreEqual("For practice, number is: " + test + "\n", game.Practice(test));
        }
        [TestMethod()]
        public void ResultRoundTest()
        {
            int test = 5;
            Assert.AreEqual("Correct, it took " + test + " guesses\nContinue? Press any key, else q to exit", game.ResultRound(test));
        }
    }
}