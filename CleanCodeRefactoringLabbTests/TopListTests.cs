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
    }
}