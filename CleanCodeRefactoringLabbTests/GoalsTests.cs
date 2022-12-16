using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeRefactoringLabb.Tests
{
    [TestClass()]
    public class GoalsTests
    {
        [TestMethod()]
        public void makeGoalTest()
        {
            string number = Goals.makeGoal().ToString();
            string numberLength = "    ";
            Assert.AreEqual(number.Count(), numberLength.Count());
        }
        [TestMethod()]
        public void checkGuessTest()
        {
            string rightGuess = "1234";
            string wrongGuess = "2111";
            string goal = "1234";
            Assert.AreEqual("RRRR,", Goals.checkGuess(goal, rightGuess));
            Assert.AreEqual(",WWWW", Goals.checkGuess(goal, wrongGuess));
        }
    }
}