
namespace CleanCodeRefactoringLabb
{
    public class Game
    {
        public void MooGame(string name) {
            string answer;
			do {
				string goal = Goals.MakeGoal().ToString();
				
                Console.WriteLine(NewGame());
				//comment out or remove next line to play real games!
				Console.WriteLine(Practice(goal));
				string guess = Console.ReadLine();
				
				int numberOfGuesses = 1;
				string goalCheck = Goals.CheckGuess(goal, guess);
				Console.WriteLine(goalCheck + "\n");
				while (goalCheck != "RRRR,")
				{
					numberOfGuesses++;
					guess = Console.ReadLine();
					Console.WriteLine(guess + "\n");
					goalCheck = Goals.CheckGuess(goal, guess);
					Console.WriteLine(goalCheck + "\n");
				}
				TopList.WriteScore(name, numberOfGuesses);
				TopList.ShowTopList();
				Console.WriteLine(ResultRound(numberOfGuesses));
				answer = Console.ReadLine();
			} while(answer != "q");
        }
		
		public string Welcome() {
			return "Press q for Exit\nor\nEnter your user name:\n";
		}
        public string NewGame() {
			return "New game:\n";
		}
		public string Practice(string goal) {
			return "For practice, number is: " + goal + "\n";
		}
		public string ResultRound(int numberOfGuesses) {
			return "Correct, it took " + numberOfGuesses + " guesses\nContinue? Press any key, else q to exit";
		}
    }
}