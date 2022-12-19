using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeRefactoringLabb.Tests
{
    [TestClass()]
    public class GoalsTests
    {
        [TestMethod()]
        public void CakeGoalTest()
        {
            string numberTest = Goals.MakeGoal().ToString();
            string numberLengthTest = "    ";
            Assert.AreEqual(numberTest.Count(), numberLengthTest.Count());
        }
        [TestMethod()]
        public void CheckGuessTest()
        {
            string rightGuessTest = "1234";
            string wrongGuessTest = "2111";
            string goal = "1234";
            Assert.AreEqual("BBBB,", Goals.CheckBullsAndCows(goal, rightGuessTest));
            Assert.AreEqual(",CCCC", Goals.CheckBullsAndCows(goal, wrongGuessTest));
        }
    }
}