
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

		public static string CheckBullsAndCows(string goal, string guess)
		{
			int bulls = 0;
			int cows = 0;
			guess += "    ";
			for(int i = 0; i < 4; i++) {
				if (goal[i] == guess[i]) {
					bulls++;
				} else {
					cows++;
				}
			}
			return "BBBB".Substring(0, bulls) + "," + "CCCC".Substring(0, cows);
		}
    }
}