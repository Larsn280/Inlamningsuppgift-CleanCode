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
    }
}