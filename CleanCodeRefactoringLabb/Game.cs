
namespace CleanCodeRefactoringLabb
{
    public class Game
    {
		public string Welcome() {
			return "Enter your user name:\n";
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


        
        public void Play(string name) {
            string answer;
			do {
				string goal = Goals.makeGoal().ToString();
				
                Console.WriteLine(NewGame());
				//comment out or remove next line to play real games!
				Console.WriteLine(Practice(goal));
				string guess = Console.ReadLine();
				
				int numberOfGuesses = 1;
				string goalCheck = Goals.checkGuess(goal, guess);
				Console.WriteLine(goalCheck + "\n");
				while (goalCheck != "RRRR,")
				{
					numberOfGuesses++;
					guess = Console.ReadLine();
					Console.WriteLine(guess + "\n");
					goalCheck = Goals.checkGuess(goal, guess);
					Console.WriteLine(goalCheck + "\n");
				}
				StreamWriter output = new StreamWriter("result.txt", append: true);
				output.WriteLine(name + "#&#" + numberOfGuesses);
				output.Close();
				TopList.showTopList();
				Console.WriteLine(ResultRound(numberOfGuesses));
				goal = "";
				answer = Console.ReadLine();
			} while(answer != "q");
        }
    }
}