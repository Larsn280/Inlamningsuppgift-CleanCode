
namespace CleanCodeRefactoringLabb
{
    public class Goals
    {
		public static int MakeGoal()
		{
			Random randomGenerator = new Random(); 
			int goal = randomGenerator.Next(1000, 10000);
			return goal;
		}

		public static string CheckGuess(string goal, string guess)
		{
			int rightGuess = 0;
			int wrongGuess = 0;
			guess += "    ";
			for(int i = 0; i < 4; i++) {
				if (goal[i] == guess[i]) {
					rightGuess++;
				} else {
					wrongGuess++;
				}
			}
			return "RRRR".Substring(0, rightGuess) + "," + "WWWW".Substring(0, wrongGuess);
		}
    }
}