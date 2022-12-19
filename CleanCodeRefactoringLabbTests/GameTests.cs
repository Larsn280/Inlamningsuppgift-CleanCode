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
            Assert.AreEqual("Press q to Exit\nor\nEnter your user name:\n", game.Welcome());
        }
    }
}