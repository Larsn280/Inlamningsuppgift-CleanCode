using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeRefactoringLabb.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void WelcomeTest()
        {
            Game game = new Game();
            Assert.AreEqual("Enter your user name:\n", game.Welcome());
        }
    }
}